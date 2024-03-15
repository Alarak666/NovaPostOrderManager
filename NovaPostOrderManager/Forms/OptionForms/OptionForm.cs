using Core.Constants.DefaultValues;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NovaPostOrderManager.Forms.OptionForms
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            LoadApiKeyIntoTextBox();
            LinkNovaPost.Links.Add(new LinkLabel.Link
            {
                LinkData = "https://new.novaposhta.ua/dashboard/settings/developers"
            });
            LinkNovaPost.LinkClicked += LinkNovaPostLinkClicked;

            textBox1.KeyDown += TextBox1OnKeyDown;

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
        private void LoadApiKeyIntoTextBox()
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                string apiKey = CoreDefaultValues.ApiKey = jsonObj["ApiKey"];
                if (!string.IsNullOrEmpty(apiKey))
                {
                    textBox1.Text = apiKey;
                }
            }
        }

        void TextBox1OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CoreDefaultValues.ApiKey = textBox1.Text;
                UpdateApiKeyInSettings(textBox1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void UpdateApiKeyInSettings(string newApiKey)
        {
            var exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(exeDirectory, "settings.json");

            var json = File.ReadAllText(filePath);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            CoreDefaultValues.ApiKey = jsonObj["ApiKey"] = newApiKey;

            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }
    }
}
