using ApplicationManager.Services;
using Core.Model;

namespace NovaPostOrderManager.Forms.OrderForms
{
    public partial class Order : Form
    {
        private OrderPostService _orderPostService = new();
        public Order()
        {
            InitializeComponent();
            LoadGrid();
            DataGridOrder.ReadOnly = true;
            DataGridOrder.CellDoubleClick += DataGridOrder_CellDoubleClick;
        }

        private async void LoadGrid()
        {
            DataGridOrder.DataSource = await _orderPostService.GetOrders();
        }


        private void DataGridOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var selectedRow = DataGridOrder.Rows[e.RowIndex];
            var cityRecipient = selectedRow.Cells["CityReceiver"].Value?.ToString();
            var recipient = selectedRow.Cells["FullName"].Value?.ToString();
            var recipientAddress = selectedRow.Cells["IDWhs"].Value?.ToString();
            var recipientsPhone = selectedRow.Cells["customerPhone"].Value?.ToString();
            var cost = (decimal)selectedRow.Cells["Cost"].Value;

            using (var orderCreate = new OrderCreate(new InternetDocumentModel
                   {
                       CityRecipient = cityRecipient,
                       Recipient = recipient,
                       RecipientAddress = recipientAddress,
                       RecipientsPhone = recipientsPhone,
                       Cost = cost,
                   }, _orderPostService))
            {
                orderCreate.ShowDialog();

                if (orderCreate.DialogResult == DialogResult.OK)
                {
                }
            }
        }
    }
}
