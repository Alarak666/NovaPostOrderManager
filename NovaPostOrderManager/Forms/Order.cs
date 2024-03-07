using ApplicationManager.Services;

namespace NovaPostOrderManager.Forms
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            var orderPostService = new OrderPostService();
            DataGridOrder.DataSource = orderPostService.GetOrders();
        }
    }
}
