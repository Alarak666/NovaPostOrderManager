using ApplicationManager.Services.DataBaseService;
using ApplicationManager.Services.NovaPostService;
using Core.Constants.DefaultValues;
using Core.Dto.AdditionalServices.CheckPossibilityCreateReturns;
using Core.Dto.AdditionalServices.GetReturnReasons;
using Core.Dto.AdditionalServices.GetReturnReasonsSubtypes;
using Core.Dto.AdditionalServices.Saves;
using Core.Dto.InternetDocuments.GetDocumentList;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text.RegularExpressions;

namespace NovaPostOrderManager.Forms.InternetDocumentForms
{
    public partial class InternetDocumentForm : Form
    {
        //property save info
        private string _startDate;
        private int _indexGridForReturn = -1;
        private string _endDate;

        //property for pagination
        private int count;
        private int page = 1;

        private readonly InternetDocumentService _internetDocumentService;
        private readonly InternetDocumentDataBaseService _internetDocumentDataBaseService;
        private readonly AdditionalServiceService _additionalServiceService;

        public InternetDocumentForm()
        {
            _additionalServiceService = new AdditionalServiceService();
            InitializeComponent();
            _internetDocumentService = new InternetDocumentService();
            _internetDocumentDataBaseService = new InternetDocumentDataBaseService();
            _startDate = DTPStart.Value.ToString("dd.MM.yyyy");
            _endDate = DTPEnd.Value.ToString("dd.MM.yyyy");
            DataGridInternetDocument.CellFormatting += DataGridInternetDocument_CellFormatting;
            // Подписываемся на события изменения значения
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            FindByPhone.Mask = "+38(999)99-99-999";
            LoadGrid();
            OptionGrid();
        }

        private void OptionGrid()
        {
            DataGridInternetDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridInternetDocument.ScrollBars = ScrollBars.Both;
            DataGridInternetDocument.AllowUserToOrderColumns = true;
            DataGridInternetDocument.ReadOnly = true;
        }


        private async Task LoadGrid()
        {
            var dataApteka = await _internetDocumentDataBaseService.GetApteka();
            var prefix = dataApteka.Rows[0]["prefix"].ToString();

            var response = await _internetDocumentService.GetDocumentList(new GetDocumentListProperty
            {
                DateTimeFrom = _startDate,
                DateTimeTo = _endDate,
                GetFullList = FilterFlag.Checked ? "1" : "0",
                Page = page.ToString(),
            });
            DataTable dataTable = new DataTable();

            var properties = typeof(GetDocumentListData).GetProperties();

            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            //Фільтер
            ICollection<GetDocumentListData> dataFilter = response.data;
            //По аптекі
            if (CheckOnlyCurrentApteka.Checked && prefix != null)
            {
                dataFilter = dataFilter.Where(x => x.InfoRegClientBarcodes.StartsWith(prefix)).ToList();
            }

            //по адресу
            if (!string.IsNullOrWhiteSpace(FindByAddress.Text) && prefix != null)
            {
                dataFilter = dataFilter.Where(x => x.SenderAddressDescription.Contains(FindByAddress.Text)).ToList();
            }

            //по телефону
            var phoneNumber = Regex.Replace(FindByPhone.Text, @"^\+38|\D", "");

            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                dataFilter = dataFilter.Where(x => x.SendersPhone.Contains(phoneNumber)).ToList();
            }

            foreach (var item in dataFilter)
            {
                var row = dataTable.NewRow();
                foreach (var property in properties)
                {
                    row[property.Name] = property.GetValue(item);
                }

                dataTable.Rows.Add(row);
            }

            DataGridInternetDocument.DataSource = dataTable /*.ToList()*/;
            if (response.info != null)
            {
                var infoObject = JObject.Parse(response.info.ToString());
                count = infoObject["totalCount"].Value<int>();
            }

            if (response.data.Count > 0)
            {
                UpdateGridHeaders();
                SetColumnIndex();
            }

            if (FilterFlag.Checked)
                UpdateNavigationLabelToFilter(dataFilter.Count);
            else
                UpdateNavigationLabel();
        }
        private void DataGridInternetDocument_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridInternetDocument.Columns[e.ColumnIndex].Name == nameof(GetDocumentListData.StateName))
            {
                // Получаем значение StateId для текущей строки
                int statusValue = Convert.ToInt32(DataGridInternetDocument.Rows[e.RowIndex].Cells[nameof(GetDocumentListData.StateId)].Value);

                switch (statusValue)
                {
                    case 1: // "Відправник самостійно створив цю накладну, але ще не надав до відправки"
                        e.CellStyle.BackColor = Color.LightGray;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 2: // "Видалено"
                        e.CellStyle.BackColor = Color.Silver;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 3: // "Номер не знайдено"
                        e.CellStyle.BackColor = Color.DarkGray;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case 4: // "Відправлення у місті ХХXХ. (Статус для межобластных отправлений)"
                    case 41: // "Відправлення у місті ХХXХ. (Статус для услуг локал стандарт и локал экспресс - доставка в пределах города)"
                        e.CellStyle.BackColor = Color.LightSkyBlue;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 5:
                    case 6: // "Відправлення прямує до міста YYYY" і "Відправлення у місті YYYY, орієнтовна доставка..."
                        e.CellStyle.BackColor = Color.LightBlue;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 7: // "Прибув на відділення"
                    case 9: // "Відправлення отримано"
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 8: // "Прибув на відділення (завантажено в Поштомат)"
                        e.CellStyle.BackColor = Color.LightYellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 10: // "Відправлення отримано %DateReceived%. Протягом доби..."
                    case 11: // "Відправлення отримано %DateReceived%. Грошовий переказ видано одержувачу."
                        e.CellStyle.BackColor = Color.MediumSeaGreen;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 12: // "Нова Пошта комплектує ваше відправлення"
                        e.CellStyle.BackColor = Color.MediumPurple;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case 101: // "На шляху до одержувача"
                        e.CellStyle.BackColor = Color.CadetBlue;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 102: // "Відмова від отримання"
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 103: // "Відмова одержувача"
                        e.CellStyle.BackColor = Color.OrangeRed;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 104: // "Змінено адресу"
                        e.CellStyle.BackColor = Color.Gold;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 105: // "Припинено зберігання"
                        e.CellStyle.BackColor = Color.Tomato;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 106: // "Одержано і створено ЄН зворотньої доставки"
                        e.CellStyle.BackColor = Color.PeachPuff;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 111: // "Невдала спроба доставки через відсутність Одержувача на адресі або зв'язок з ним"
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case 112: // "Дата доставки перенесена Одержувачем"
                        e.CellStyle.BackColor = Color.LightSalmon;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    default:
                        e.CellStyle.BackColor = Color.White; // Цвет по умолчанию для неопределенных или новых статусов
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void SetColumnIndex()
        {
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.DisplayIndex = 0;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.DisplayIndex = 1;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.DisplayIndex = 2;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.DisplayIndex = 3;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.DisplayIndex = 4;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.DisplayIndex = 5;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.DisplayIndex = 6;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.DisplayIndex = 7;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Description)]!.DisplayIndex = 8;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderContactPerson)]!.DisplayIndex = 9;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddressDescription)]!.DisplayIndex = 10;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SendersPhone)]!.DisplayIndex = 11;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientContactPerson)]!.DisplayIndex = 12;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientsPhone)]!.DisplayIndex = 13;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipientDescription)]!.DisplayIndex = 14;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddressDescription)]!.DisplayIndex = 15;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateId)]!.DisplayIndex = 16;
        }

        private void UpdateGridHeaders()
        {
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.HeaderText = CoreDefaultValues.GetInternetDocumentIntDocNumber;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.HeaderText = CoreDefaultValues.GetInternetDocumentStateName;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.HeaderText = CoreDefaultValues.GetInternetDocumentInfoRegClientBarcodes;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDateTime;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCostOnSite;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.HeaderText = CoreDefaultValues.GetInternetDocumentWeight;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Description)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderAddressDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SendersPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSendersPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentAfterpaymentOnGoodsCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientsPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientsPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipientDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCityRecipientDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientAddressDescription;
            //HideField
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.Visible = false;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateId)]!.Visible = false;
            //Order
            foreach (DataGridViewColumn column in DataGridInternetDocument.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void DTPStart_ValueChanged(object? sender, EventArgs e)
        {
            _startDate = DTPStart.Value.ToString("dd.MM.yyyy");
        }

        private void DTPEnd_ValueChanged(object? sender, EventArgs e)
        {
            _endDate = DTPEnd.Value.ToString("dd.MM.yyyy");
        }

        private async void BLoad_Click(object sender, EventArgs e)
        {
            await LoadGrid();
        }

        private async void BReturn_Click(object sender, EventArgs e)
        {
            if (_indexGridForReturn != -1)
            {
                var intDocNumber = DataGridInternetDocument.Rows[_indexGridForReturn].Cells[nameof(GetDocumentListData.IntDocNumber)].Value?.ToString();
                //запрос, ми можем зробити повернення
                var checkPossibilityCreateReturn = await _additionalServiceService.CheckPossibilityCreateReturn(new CheckPossibilityCreateReturnProperty
                {
                    Number = intDocNumber,
                });
                await Task.Delay(100);
                //запит причини повернення 
                var getReturnReasonResponse = await _additionalServiceService.GetReturnReason(new GetReturnReasonProperty());
                await Task.Delay(100);

                //під запит причини повернення 
                var getReturnReasonsSubtypeResponse = await _additionalServiceService.GetReturnReasonsSubtype(new GetReturnReasonsSubtypeProperty
                {
                    ReasonRef = getReturnReasonResponse.data[0].Ref
                });
                await Task.Delay(100);

                if (checkPossibilityCreateReturn.data.Count > 0)
                {
                    CheckPossibilityCreateReturnData data = checkPossibilityCreateReturn.data[0];
                    var responseSave = await _additionalServiceService.Save(new SaveProperty
                    {
                        IntDocNumber = intDocNumber,
                        PaymentMethod = data.NonCash ? "NonCash" : "Cash",
                        Reason = getReturnReasonResponse.data[0].Ref,
                        SubtypeReason = getReturnReasonsSubtypeResponse.data[0].ReasonRef,
                        Note = "Повернення на аптеку",
                        OrderType = "orderCargoReturn",
                        ReturnAddressRef = data.Address
                    });
                }
            }
            else
            {
            }
        }

        private void DataGridInternetDocument_DoubleClick(object sender, EventArgs e)
        {
            _indexGridForReturn = DataGridInternetDocument.SelectedRows.Count > 0 ?
                DataGridInternetDocument.SelectedRows[0].Index :
                -1;
        }
        private void UpdateNavigationLabel()
        {
            // Вычисляем диапазон элементов, отображаемых на текущей странице
            int startItemIndex = (page - 1) * 100 + 1;
            int endItemIndex = Math.Min(page * 100, count); // Не должно превышать totalCount

            toolStripLCount.Text = $"Показано элементов {startItemIndex} - {endItemIndex} из {count}";
        }
        private void UpdateNavigationLabelToFilter(int filterCount)
        {
            // Вычисляем диапазон элементов, отображаемых на текущей странице

            toolStripLCount.Text = $"Показано элементов {filterCount}";
        }
        private async void toolStripBack_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                await LoadGrid();
            }
        }

        private async void toolStripNext_Click(object sender, EventArgs e)
        {
            int maxPage = (int)Math.Ceiling(count / 100.0); // Вычисляем максимальное количество страниц
            if (page < maxPage)
            {
                page++;
                await LoadGrid();
            }
        }
    }
}
