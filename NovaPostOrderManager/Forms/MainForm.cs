using Core.Constants.DefaultValues;
using Core.CustomException;
using Newtonsoft.Json;
using NovaPostOrderManager.Forms.AddressForms;
using NovaPostOrderManager.Forms.InternetDocumentForms;
using NovaPostOrderManager.Forms.OptionForms;
using NovaPostOrderManager.Forms.OrderForms;

namespace NovaPostOrderManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
