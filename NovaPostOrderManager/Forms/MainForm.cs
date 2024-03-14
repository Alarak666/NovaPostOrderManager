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

        private void BCity_Click(object sender, EventArgs e)
        {
            using (var searchSettlement = new SearchSettlement())
            {
                searchSettlement.ShowDialog();
            }
        }

        private void BOrder_Click(object sender, EventArgs e)
        {
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
            using (var documentForm = new InternetDocumentForm())
            {
                documentForm.ShowDialog();
            }
        }
    }
}
