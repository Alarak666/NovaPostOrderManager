using ApplicationManager.Services.SupportService;
using Core.Constants.DefaultValues;
using Core.CustomException;
using Newtonsoft.Json;
using NovaPostOrderManager.Forms.AddressForms;
using NovaPostOrderManager.Forms.InternetDocumentForms;
using NovaPostOrderManager.Forms.OptionForms;
using NovaPostOrderManager.Forms.OrderForms;

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
        private bool ApiKeyIsSet()
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                string apiKey = jsonObj["ApiKey"];
                //load if no 
                CoreDefaultValues.ApiKey = jsonObj["ApiKey"];
                CoreDefaultValues.Server = jsonObj["Server"];
                if (string.IsNullOrEmpty(apiKey))
                    throw new CustomException("Встановіть ApiKey Нової пошти, в налаштуваннях");
            }
            else
                throw new CustomException("Встановіть ApiKey Нової пошти, в налаштуваннях");

            return true;

        }
        private void BCity_Click(object sender, EventArgs e)
        {
            if (!ApiKeyIsSet())
                return;
            using (var searchSettlement = new SearchSettlement())
            {
                searchSettlement.ShowDialog();
            }
        }

        private void BOrder_Click(object sender, EventArgs e)
        {
            if (!ApiKeyIsSet())
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

        private void BInternetDocument_Click(object sender, EventArgs e)
        {
            if (!ApiKeyIsSet())
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
