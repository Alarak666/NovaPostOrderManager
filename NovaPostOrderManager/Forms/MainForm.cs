using NovaPostOrderManager.Forms;

namespace NovaPostOrderManager
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
    }
}
