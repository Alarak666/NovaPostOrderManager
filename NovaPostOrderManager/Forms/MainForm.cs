using ApplicationManager.Helpers;
using ApplicationManager.Services.NovaPostService;
using ApplicationManager.Services.SupportService;
using Core.Constants.DefaultValues;
using Core.CustomException;
using Core.Model;
using Newtonsoft.Json;
using NovaPostOrderManager.Forms.AddressForms;
using NovaPostOrderManager.Forms.InternetDocumentForms;
using NovaPostOrderManager.Forms.OptionForms;
using NovaPostOrderManager.Forms.OrderForms;
using System.Configuration;

namespace NovaPostOrderManager.Forms
{
    public sealed partial class MainForm : Form
    {
        private readonly VersionChecker _versionChecker;

        public MainForm()
        {
            InitializeComponent();
            Text = $"Головне меню :: версія {CoreDefaultValues.Version}";
            _versionChecker = new VersionChecker();
            _versionChecker.VersionMismatch += VersionChecker_VersionMismatch;
            _versionChecker.StartChecking();
        }

        private void VersionChecker_VersionMismatch(object sender, EventArgs e)
        {
            // Виконується в іншому потоці, тому для змін UI використовуємо Invoke
            Invoke(() =>
            {
                MessageBox.Show("Версія додатку застаріла. Будь ласка, закрийте додаток і оновіть його.", "Необхідне оновлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }
        private async Task<bool> ApiKeyIsSet()
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            if (File.Exists(filePath))
            {
                var json = await File.ReadAllTextAsync(filePath);
                Settings settings = JsonConvert.DeserializeObject<Settings>(json) ?? new Settings();
                string apiKey = settings.ApiKey;
                //load if no 
                CoreDefaultValues.ApiKey = settings.ApiKey ?? "";
                CoreDefaultValues.Server = settings.Server ?? "";
                CoreDefaultValues.AddressApteka = settings.UserData?.Address ?? "";
                CoreDefaultValues.ContactApteka = settings.UserData?.Contact ?? "";
                CoreDefaultValues.PhoneApteka = settings.UserData?.Phone ?? "";

                if (string.IsNullOrEmpty(apiKey))
                    throw new CustomException("Встановіть ApiKey Нової пошти, в налаштуваннях");
                else
                    await CheckValidApiKey.IsValidApiKey();

                if (string.IsNullOrEmpty(CoreDefaultValues.AddressApteka))
                    throw new CustomException("Адреса аптеки не може бути порожньою.");

                // Перевірка, що контактна інформація аптеки не порожня
                if (string.IsNullOrEmpty(CoreDefaultValues.ContactApteka))
                    throw new CustomException("Контактна інформація аптеки не може бути порожньою.");

                // Перевірка, що телефонний номер аптеки не порожній і відповідає формату
                if (string.IsNullOrEmpty(CoreDefaultValues.PhoneApteka))
                    throw new CustomException("Телефонний номер аптеки не може бути порожнім.");
            }
            else
                throw new CustomException("Встановіть ApiKey Нової пошти, в налаштуваннях");

            return true;

        }

        private async void BCity_Click(object sender, EventArgs e)
        {
            if ( !await ApiKeyIsSet())
                return;
            using (var searchSettlement = new SearchSettlement())
            {
                searchSettlement.ShowDialog();
            }
        }

        private async void BOrder_Click(object sender, EventArgs e)
        {
            if (!await ApiKeyIsSet())
                return;
            using (var order = new Order())
            {
                order.ShowDialog();
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            using (var optionForm = new OptionForm())
            {
                optionForm.ShowDialog();
            }
        }

        private async void BInternetDocument_Click(object sender, EventArgs e)
        {
            if (!await ApiKeyIsSet())
                return;
            using (var documentForm = new InternetDocumentForm())
            {
                documentForm.ShowDialog();
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var getLogService = new GetLogService();
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            var sendRemovedFiles = new List<string>
            {
                Path.Combine(baseDirectory, "Log.txt"),
                Path.Combine(baseDirectory, $"log-{DateTime.Now.Date:yyyyMMdd}.txt")
            };

            for (var i = 0; i <= 4; i++)
            {
                var logFilePath = Path.Combine(baseDirectory, $"log-{DateTime.Now.Date.AddDays(-i):yyyyMMdd}.txt");
                if (File.Exists(logFilePath))
                {
                    sendRemovedFiles.Add(logFilePath);
                }
            }
            var sendFiles = new List<string>();
            foreach (var item in sendRemovedFiles)
            {
                if (File.Exists(item))
                {
                    sendFiles.Add(item);
                }
            }

            if (sendFiles.Count > 0)
            {
                await getLogService.SendLogToEmail("m.popelnytskyi@fozzy.ua", sendFiles.ToArray());
                MessageBox.Show("Файл відправлено дякую.");
            }
            else
                MessageBox.Show("Файл лога не знайдено.");
        }
    }
}
