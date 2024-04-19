using ApplicationManager.Helpers;
using ApplicationManager.Services.NovaPostService;
using Core.Constants.DefaultValues;
using Core.Dto.Conterparties.GetCounterparties.Response;
using Core.Dto.Conterparties.GetCounterpartyAddresses;
using Core.Dto.Conterparties.GetCounterpartyAddresses.Response;
using Core.Dto.Conterparties.GetCounterpartyContactPersons;
using Core.Dto.Conterparties.GetCounterpartyContactPersons.Response;
using Core.Model;
using FuzzySharp;
using Newtonsoft.Json;
using System.Diagnostics;
using Process = System.Diagnostics.Process;

namespace NovaPostOrderManager.Forms.OptionForms
{
    public partial class OptionForm : Form
    {
        private GetCounterpartyResponse? conterparty;
        private GetCounterpartyAddressesResponse? conterpartyAddress;
        private GetCounterpartyContactPersonsResponse? counterpartyContactPersons;
        private readonly CounterpartyService _counterpartyService;
        public OptionForm()
        {
            _counterpartyService = new CounterpartyService();
            InitializeComponent();
            LoadApiKeyIntoTextBox();
            LinkNovaPost.Links.Add(new LinkLabel.Link
            {
                LinkData = "https://new.novaposhta.ua/dashboard/settings/developers"
            });
            textBox1.KeyDown += TextBox1OnKeyDown;
            LinkNovaPost.LinkClicked += LinkNovaPostLinkClicked;
            TBSearchAddress.LostFocus += new EventHandler(TBSearchAddress_LostFocus);
            TBSearchContacts.LostFocus += new EventHandler(TBSearchContacts_LostFocus);
        }

        private void TBSearchAddress_LostFocus(object? sender, EventArgs e)
        {
            FindCbSenderAddress(TBSearchAddress.Text);
        }
        private void TBSearchContacts_LostFocus(object? sender, EventArgs e)
        {
            FindTbSearchContacts(TBSearchContacts.Text);
        }
        private void FindCbSenderAddress(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                CBSenderAddress.DataSource = conterpartyAddress.data;
            else
            {
                int threshold = 70;
                var filteredItems = new List<GetCounterpartyAddressesData>();
                foreach (var item in conterpartyAddress.data)
                {
                    var score = Fuzz.PartialRatio(input.ToLower(), item.Description.ToLower());

                    if (score >= threshold)
                    {
                        filteredItems.Add(item);
                    }
                }
                // Обновляем данные в ComboBox
                CBSenderAddress.DataSource = filteredItems;
                CBSenderAddress.DisplayMember = "Description";
                CBSenderAddress.ValueMember = "Ref";
            }

        }
        private void FindTbSearchContacts(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                CBContactSender.DataSource = counterpartyContactPersons.data;
            else
            {
                int threshold = 70;
                var filteredItems = new List<GetCounterpartyContactPersonsData>();
                foreach (var item in counterpartyContactPersons.data)
                {
                    var score = Fuzz.PartialRatio(input.ToLower(), item.Description.ToLower());

                    if (score >= threshold)
                    {
                        filteredItems.Add(item);
                    }
                }
                // Обновляем данные в ComboBox
                CBContactSender.DataSource = filteredItems;
                CBContactSender.DisplayMember = "Description";
                CBContactSender.ValueMember = "Ref";
            }
        }
        private async Task LoadField()
        {
            await CheckValidApiKey.IsValidApiKey();
            await Task.Delay(100);
            // ДЛя начала ключ нужен 
            conterparty = await _counterpartyService.GetCounterparty("Sender");
            await Task.Delay(100);
            //Найти адреса контре ангента
            conterpartyAddress = await _counterpartyService.GetCounterpartyAddresses("Sender", conterparty.data[0].Ref);
            await Task.Delay(100);
            //Найти отправителя, контр агент 
            counterpartyContactPersons = await _counterpartyService.GetCounterpartyContactPersons(conterparty.data[0].Ref);
            await Task.Delay(100);

            //Контакт
            CBContactSender.DataSource = counterpartyContactPersons.data;
            CBContactSender.DisplayMember = "Description";
            CBContactSender.ValueMember = "Ref";
            //
            //Адреса
            CBSenderAddress.DataSource = conterpartyAddress.data;
            CBSenderAddress.DisplayMember = "Description";
            CBSenderAddress.ValueMember = "Ref";
            //Телефон
            TSendersPhone.Text = counterpartyContactPersons.data[0].Phones;
            //
        }

        private void LinkNovaPostLinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие ссылки в браузере по умолчанию
            var url = e.Link?.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start {url}",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };
                Process.Start(psi);
            }
        }
        private async void LoadApiKeyIntoTextBox()
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            if (File.Exists(filePath))
            {
                var json = await File.ReadAllTextAsync(filePath);
                var settings = JsonConvert.DeserializeObject<Settings>(json);

                CoreDefaultValues.ApiKey = settings?.ApiKey ?? "";
                CoreDefaultValues.AddressApteka = settings?.UserData?.Address ?? "";
                CoreDefaultValues.ContactApteka = settings?.UserData?.Contact ?? "";
                CoreDefaultValues.PhoneApteka = settings?.UserData?.Phone ?? "";

                if (!string.IsNullOrEmpty(CoreDefaultValues.ApiKey))
                {
                    textBox1.Text = CoreDefaultValues.ApiKey;
                    await LoadField();
                    IsVisible(true);
                }
                else
                {
                    IsVisible(false);
                    return;
                }

                if (!string.IsNullOrEmpty(CoreDefaultValues.ContactApteka))
                {
                    foreach (var item in CBContactSender.Items)
                    {
                        if ((item as GetCounterpartyContactPersonsData)?.Ref == CoreDefaultValues.ContactApteka) // YourDataType - это тип элементов в DataSource
                        {
                            CBContactSender.SelectedItem = item;
                            break;
                        }
                    }
                }

                // Установка выбранного значения для CBSenderAddress
                if (!string.IsNullOrEmpty(CoreDefaultValues.AddressApteka))
                {
                    foreach (var item in CBSenderAddress.Items)
                    {
                        if ((item as GetCounterpartyAddressesData)?.Ref == CoreDefaultValues.AddressApteka) // YourDataType - это тип элементов в DataSource
                        {
                            CBSenderAddress.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void IsVisible(bool isVisibleMode)
        {
            CBContactSender.Visible = isVisibleMode;
            CBSenderAddress.Visible = isVisibleMode;
            TSendersPhone.Visible = isVisibleMode;
            label14.Visible = isVisibleMode;
            label15.Visible = isVisibleMode;
            LSendersPhone.Visible = isVisibleMode;
            BSave.Visible = isVisibleMode;
            TBSearchAddress.Visible = isVisibleMode;
            TBSearchContacts.Visible = isVisibleMode;
        }

        private async void TextBox1OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            UpdateApiKeyInSettings(textBox1.Text, "", "", "");

            if (CoreDefaultValues.ApiKey != "")
            {
                await LoadField();
                LoadApiKeyIntoTextBox();
                IsVisible(true);
            }
            else
                IsVisible(false);

        }
        private void BSave_Click(object sender, EventArgs e)
        {
            UpdateApiKeyInSettings(textBox1.Text, CBSenderAddress.SelectedValue?.ToString() ?? "", CBContactSender.SelectedValue?.ToString() ?? "", TSendersPhone.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateApiKeyInSettings(string newApiKey, string newAddress, string newContact, string newPhone)
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            var json = File.ReadAllText(filePath);
            var settings = JsonConvert.DeserializeObject<Settings>(json);

            CoreDefaultValues.ApiKey = settings.ApiKey = newApiKey;
            CoreDefaultValues.AddressApteka = settings.UserData.Address = newAddress;
            CoreDefaultValues.ContactApteka = settings.UserData.Contact = newContact;
            CoreDefaultValues.PhoneApteka = settings.UserData.Phone = newPhone;

            string output = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }

        private void CBContactSender_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBContactSender.SelectedValue != null)
            {
                var selectedRef = "";
                if (CBContactSender.SelectedValue is GetCounterpartyContactPersonsData data)
                {
                    selectedRef = data.Ref;
                }
                else
                {
                    selectedRef = CBContactSender.SelectedValue.ToString();
                }
                var contactPerson = counterpartyContactPersons?.data.FirstOrDefault(x => x.Ref == selectedRef);
                TSendersPhone.Text = contactPerson?.Phones;
            }
            else
            {
                TSendersPhone.Text = string.Empty;
            }
        }

    }
}
