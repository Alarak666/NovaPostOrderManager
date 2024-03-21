using ApplicationManager.Helpers;
using ApplicationManager.Validation;
using Core.Constants.Enums;
using Core.Dto.Commons.GetCargoTypes;
using Core.Dto.Conterparties.CreateCounterparties;
using Core.Dto.Conterparties.GetCounterparties;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using Core.Dto.Settlements.GetWarehouses;
using Core.Model;
using FluentValidation.Results;
using System.Globalization;
using System.Text.RegularExpressions;
using Core.Constants.DefaultValues;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Diagnostics;
using ApplicationManager.Services.NovaPostService;
using ApplicationManager.Services.DataBaseService;

namespace NovaPostOrderManager.Forms.OrderForms
{
    public partial class OrderCreate : Form
    {
        private readonly InternetDocumentModel _internetDocumentModel;
        private readonly OrderPostDataBaseService _orderPostService;
        private readonly CounterpartyService _counterpartyService;
        private readonly SearchSettlementService _searchSettlementService;
        private readonly InternetDocumentService _internetDocumentService;
        private readonly CommonService _commonService;
        // Поля для зберігання 
        private string _id;
        private string? _infoRegClientBarcodes;
        //Номер ТТН
        private string? _documentNumber = "";

        // Відділення нової почти 
        private GetWarehouseResponseData data = new();

        private string RecipientWarehouseIndex { get; set; }
        //
        public OrderCreate(InternetDocumentModel internetDocumentModel, OrderPostDataBaseService orderPostService, string id, string? infoRegClientBarcodes)
        {
            _internetDocumentModel = internetDocumentModel;
            _orderPostService = orderPostService;
            _internetDocumentService = new InternetDocumentService();
            _counterpartyService = new CounterpartyService();
            _searchSettlementService = new SearchSettlementService();
            _id = id;
            _infoRegClientBarcodes = infoRegClientBarcodes;
            _commonService = new CommonService();
            InitializeComponent();
            InitializeField();
            LoadField();
        }
        private void SetComboBoxDataSource<T>(ComboBox comboBox) where T : Enum
        {
            var enumValues = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            comboBox.DataSource = enumValues.Select(value => new { Value = value, DisplayName = ComponentHelper.GetEnumDescription(value) }).ToList();
            comboBox.DisplayMember = "DisplayName";
            comboBox.ValueMember = "Value";
        }

        private async Task LoadField()
        {
            SetComboBoxDataSource<PaymentMethod>(CbPaymentMethod);
            CbPaymentMethod.SelectedValue = PaymentMethod.Cash;
            SetComboBoxDataSource<PayerType>(CbPayerType);
            CbPayerType.SelectedValue = PayerType.Recipient;
            SetComboBoxDataSource<ServiceType>(CbServiceType);
            CbServiceType.SelectedValue = ServiceType.DoorsWarehouse;
            var response = await _commonService.GetCargoType();
            CbCargoType.DataSource = response.data;
            CbCargoType.DisplayMember = nameof(GetCargoTypeData.Description);
            CbCargoType.ValueMember = nameof(GetCargoTypeData.Ref);
            DtpDateTime.Value = DateTime.Now;
            //numericUpDown
            NUDCost.Maximum = Decimal.MaxValue;
            NUDDetailWidht.Maximum = int.MaxValue;
            NUDDetailHeight.Maximum = int.MaxValue;
            NUDDetailLenght.Maximum = int.MaxValue;
            NUDDetailWeight.Maximum = int.MaxValue;

        }
        private void CalculateAndDisplayResult()
        {
            var result = (NUDDetailHeight.Value * NUDDetailLenght.Value * NUDDetailWidht.Value) / 4000;
            VolumeGeneral.Text = result is > 0 and < 0.01m ? "0.01" : result > 0 ? result.ToString("N2") : string.Empty;

        }
        private async Task InitializeField()
        {
            //Отримувач
            //Кому відправка населений пункт
            var responseAddressRecipient = await _searchSettlementService.GetAddress(
                @ref: _internetDocumentModel.RecipientAddress);
            await Task.Delay(100);
            data = responseAddressRecipient.data[0];

            string[] parts = _internetDocumentModel.Recipient.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var createCounterparty = await _counterpartyService.CreateCounterparty(
                new CreateCounterpartyProperty
                {
                    FirstName = parts[1],// імя
                    MiddleName = parts.Length > 2 ? parts[2] : "",//по батькові
                    LastName = parts[0], // Прізвище
                    Phone = FormatPhoneNumber(_internetDocumentModel.RecipientsPhone),
                    Email = "",
                    CounterpartyType = "PrivatePerson",
                    CounterpartyProperty = "Recipient"
                });
            await Task.Delay(100);

            //Відправник
            //Найти контагента
            var conterparty = await _counterpartyService.GetCounterparty("Sender");
            await Task.Delay(100);
            //Найти адреса контре ангента
            var conterpartyAddress = await _counterpartyService.GetCounterpartyAddresses("Sender", conterparty.data[0].Ref);
            await Task.Delay(100);
            //Найти отправителя, контр агент 
            var counterpartyContactPersons = await _counterpartyService.GetCounterpartyContactPersons(conterparty.data[0].Ref);
            await Task.Delay(100);

            //Відправник
            //Контерагент
            CBSender.DataSource = conterparty.data;
            CBSender.DisplayMember = nameof(GetCounterpartyData.Description);
            CBSender.ValueMember = nameof(GetCounterpartyData.Ref);

            //Контакт
            CBContactSender.DataSource = counterpartyContactPersons.data;
            CBContactSender.DisplayMember = "Description";
            CBContactSender.ValueMember = "Ref";
            //

            //Місто
            CBCitySender.DataSource = conterpartyAddress.data;
            CBCitySender.DisplayMember = "CityDescription";
            CBCitySender.ValueMember = "CityRef";
            //Адреса
            CBSenderAddress.DataSource = conterpartyAddress.data;
            CBSenderAddress.DisplayMember = "Description";
            CBSenderAddress.ValueMember = "Ref";
            //Телефон
            TSendersPhone.Text = counterpartyContactPersons.data[0].Phones;
            //

            //Одержувач
            CBRecipient.DataSource = createCounterparty.data;
            CBRecipient.DisplayMember = "Description";
            CBRecipient.ValueMember = "Ref";
            //Контакт
            CBContactRecipient.DataSource = createCounterparty.data[0].ContactPerson?.data;
            CBContactRecipient.DisplayMember = "Description";
            CBContactRecipient.ValueMember = "Ref";
            //Місто
            CBCityRecipient.DataSource = new List<GetWarehouseResponseData> { data };
            CBCityRecipient.DisplayMember = "CityDescription";
            CBCityRecipient.ValueMember = "SettlementRef";
            //Адреса
            CBRecipientAddress.DataSource = new List<GetWarehouseResponseData> { data };
            CBRecipientAddress.DisplayMember = "Description";
            CBRecipientAddress.ValueMember = "Ref";
            //Телефон
            TRecipientsPhone.Text = FormatPhoneNumber(_internetDocumentModel.RecipientsPhone);
            //Склад
            RecipientWarehouseIndex = responseAddressRecipient.data[0].WarehouseIndex;
            //Parameter
            //
            NUDCost.Value = _internetDocumentModel.Cost;

            ConfigurationField();
            BCreateOrder.Enabled = true;
        }

        private void ConfigurationField()
        {
            decimal weightMaximum = decimal.Parse(data.TotalMaxWeightAllowed) > 0
                ? decimal.Parse(data.TotalMaxWeightAllowed)
                : decimal.Parse(data.PlaceMaxWeightAllowed);
            var weight = weightMaximum > 1000 ? 1000 : weightMaximum;
            //todo я изменил дата и все поля сейчас не забудь убрать перед мержем  оце поле не работа так как надо, нужно редактировать
            NUDDetailHeight.Maximum = data.ReceivingLimitationsOnDimensions.Height;
            NUDDetailHeight.Enter += numericUpDown_Enter;
            NUDDetailHeight.ValueChanged += (sender, e) => CalculateAndDisplayResult();

            NUDDetailWidht.Maximum = data.ReceivingLimitationsOnDimensions.Width;
            NUDDetailWidht.Enter += numericUpDown_Enter;
            NUDDetailWidht.ValueChanged += (sender, e) => CalculateAndDisplayResult();

            NUDDetailLenght.Maximum = data.ReceivingLimitationsOnDimensions.Length;
            NUDDetailLenght.Enter += numericUpDown_Enter;
            NUDDetailLenght.ValueChanged += (sender, e) => CalculateAndDisplayResult();

            NUDDetailWeight.Maximum = weight;
            NUDDetailWeight.Enter += numericUpDown_Enter;


            //if (postomat)
            //{//Обмеження на поштомат для місця

            //    tabControl1.TabPages.Remove(tabPage2);
            //}
            //else
            //{
            //    tabControl1.SelectedIndex = 0;
            //    NUDWeight.Maximum = weight;
            //    NUDVolumeGeneral.Maximum = weight / 250;
            //    tabControl1.TabPages.Remove(tabPage2);
            //}
        }

        private void numericUpDown_Enter(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown { Value: 0 } numericUpDown)
            {
                BeginInvoke((() => numericUpDown.Select(0, numericUpDown.Text.Length)));
            }
        }

        public string FormatPhoneNumber(string phoneNumber)
        {
            // Извлекаем только цифры из строки
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            // Добавляем префикс "+38" к оставшимся цифрам
            return $"+38{digitsOnly.Substring(2)}";
        }

        private async void BCreateOrder_Click(object sender, EventArgs e)
        {
            var volumeGeneral = ((NUDDetailHeight.Value * NUDDetailLenght.Value * NUDDetailWidht.Value) / 4000);

            var propetry = new CreateInternetDocumentProperty
            {
                SenderWarehouseIndex = "",
                RecipientWarehouseIndex = RecipientWarehouseIndex,
                PayerType = CbPayerType?.SelectedValue as PayerType?,
                PaymentMethod = CbPaymentMethod?.SelectedValue as PaymentMethod?,
                DateTime = DtpDateTime.Value.ToString("dd.MM.yyyy"),
                CargoType = CbCargoType.SelectedValue?.ToString() ?? "",
                ServiceType = ServiceType.DoorsWarehouse,
                SeatsAmount = "1",
                Description = TDescription.Text,
                Cost = decimal.Parse(data.MaxDeclaredCost) == 0 ?
                    NUDCost.Text :
                    Math.Min(decimal.Parse(NUDCost.Text), decimal.Parse(data.MaxDeclaredCost) - 1).ToString(),
                CitySender = CBCitySender.SelectedValue?.ToString() ?? "",
                Sender = CBSender.SelectedValue?.ToString() ?? "",
                SenderAddress = CBSenderAddress.SelectedValue?.ToString() ?? "",
                ContactSender = CBContactSender.SelectedValue?.ToString() ?? "",
                SendersPhone = TSendersPhone.Text,
                CityRecipient = CBCityRecipient.SelectedValue?.ToString() ?? "",
                Recipient = CBRecipient.SelectedValue?.ToString() ?? "",
                RecipientAddress = CBRecipientAddress.SelectedValue?.ToString() ?? "",
                ContactRecipient = CBContactRecipient.SelectedValue?.ToString() ?? "",
                RecipientsPhone = TRecipientsPhone.Text,
                AfterpaymentOnGoodsCost = NUDCost.Text,
                InfoRegClientBarcodes = _infoRegClientBarcodes,
                OptionsSeat = null
            };

            propetry.Weight = NUDDetailWeight.Text;
            propetry.OptionsSeat = new List<OptionsSeat>
                {
                    new ()
                    {
                        volumetricVolume = volumeGeneral,
                        volumetricWidth = (int)NUDDetailWidht.Value,
                        volumetricLength = (int)NUDDetailLenght.Value,
                        volumetricHeight = (int)NUDDetailHeight.Value,
                        weight = NUDDetailWeight.Value
                    }
                };

            if (await ValidateAccess(propetry))
            {
                var response = await _internetDocumentService.CreateInternetDocument(propetry);
                if (response.data.Count > 0)
                {
                   var updateSuccess = await _orderPostService.UpdateOrderTabletki(_id, response.data[0].IntDocNumber);
                    MessageBox.Show($"Експрес накладну створено з такими даними:\n" +
                                    $"Вартість доставки: {response.data[0].CostOnSite}\n" +
                                    $"Прогнозована дата доставки: {response.data[0].EstimatedDeliveryDate}\n" +
                                    $"ТТН: {response.data[0].IntDocNumber}\n" + 
                                    $"Номер ТТН замовлення {(updateSuccess ? "був оновлений" : "не був оновлений")}",
                        "Експрес накладна", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _documentNumber = response.data[0].IntDocNumber;
                }
                else
                {
                    MessageBox.Show($"Код помилки {string.Join(',', response.errorCodes.Select(x => x))}");
                }
            }
        }
        private async void BPrinter_Click(object sender, EventArgs e)
        {
           await _orderPostService.PrinterDocument(_documentNumber);
        }
        #region Validation
        private async Task<bool> ValidateAccess(CreateInternetDocumentProperty model)
        {
            var validator = new AccessValidator(NUDDetailWeight.Maximum);

            var validationResult = await validator.ValidateAsync(model);
            await ValidationFields(validationResult);

            return validationResult.IsValid;
        }
        private async Task ValidationFields(ValidationResult validationResult)
        {
            SetControlBorder(TDescription, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.Description)));
            SetControlBorder(CBCitySender, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.CitySender)));
            SetControlBorder(CBCityRecipient, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.CityRecipient)));
            SetControlBorder(CBSender, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.Sender)));
            SetControlBorder(CBRecipient, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.Recipient)));
            SetControlBorder(DtpDateTime, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.DateTime)));
            SetControlBorder(CbServiceType, validationResult.IsValidField(nameof(CreateInternetDocumentProperty.ServiceType)));
            //параметри
            SetControlBorder(NUDDetailHeight, validationResult.IsValidField(nameof(OptionsSeat.volumetricHeight)));
            SetControlBorder(NUDDetailWidht, validationResult.IsValidField(nameof(OptionsSeat.volumetricWidth)));
            SetControlBorder(NUDDetailLenght, validationResult.IsValidField(nameof(OptionsSeat.volumetricLength)));
            SetControlBorder(NUDDetailWeight, validationResult.IsValidField(nameof(OptionsSeat.weight)));
            if (validationResult.Errors.Count > 0)
                MessageBox.Show(string.Join(',', validationResult.Errors.Select(x => x.ErrorMessage)), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

       

        private void SetControlBorder<T>(T control, bool isValid)
        {
            if (control is TextBox textBox)
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BackColor = isValid ? SystemColors.Window : Color.Salmon;
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.CalendarMonthBackground = isValid ? SystemColors.Window : Color.Salmon;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = isValid ? SystemColors.Window : Color.Salmon;
            }
            else if (control is NumericUpDown numericUpDown)
            {
                numericUpDown.BackColor = isValid ? SystemColors.Window : Color.Salmon;
            }

            Task.Delay(2000).ContinueWith(_ =>
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.BackColor = SystemColors.Window;
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            dateTimePicker.CalendarMonthBackground = SystemColors.Window;
                        }
                        else if (control is ComboBox comboBox)
                        {
                            comboBox.BackColor = SystemColors.Window;
                        }
                    });
                }
            });
        }



        #endregion

    }
}
