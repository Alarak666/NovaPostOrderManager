using ApplicationManager.Services.DataBaseService;
using Core.Constants.DefaultValues;
using Core.CustomException;
using Core.Model;

namespace NovaPostOrderManager.Forms.OrderForms
{
    public partial class Order : Form
    {
        private OrderPostDataBaseService _orderPostService = new();
        public Order()
        {
            InitializeComponent();
            LoadGrid();
        }

        private async void LoadGrid()
        {
            DataGridOrder.DataSource = await _orderPostService.GetOrders();
            DataGridOrder.ReadOnly = true;
            DataGridOrder.ScrollBars = ScrollBars.Both;
            DataGridOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridOrder.CellDoubleClick += DataGridOrder_CellDoubleClick;

        }

        private void DataGridOrder_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var selectedRow = DataGridOrder.Rows[e.RowIndex];
            var cityRecipient = selectedRow.Cells[CoreDefaultValues.OrderTablentkiCityReceiver].Value?.ToString();
            var recipient = selectedRow.Cells[CoreDefaultValues.OrderTablentkiFullName].Value?.ToString();
            var recipientAddress = selectedRow.Cells[CoreDefaultValues.OrderTablentkiIDWhs].Value?.ToString();
            var recipientsPhone = selectedRow.Cells[CoreDefaultValues.OrderTablentkiCustomerPhone].Value?.ToString();
            var cost = (decimal)selectedRow.Cells[CoreDefaultValues.OrderTablentkiCost].Value;
            var infoRegClientBarcodes = selectedRow.Cells[CoreDefaultValues.OrderTablentkiDocumentNumber].Value.ToString();

            using (var orderCreate = new OrderCreate(new InternetDocumentModel
                   {
                       CityRecipient = cityRecipient,
                       Recipient = recipient,
                       RecipientAddress = recipientAddress,
                       RecipientsPhone = recipientsPhone,
                       Cost = cost,
                   }, _orderPostService, 
                       selectedRow.Cells[CoreDefaultValues.OrderTablentkiId].Value?.ToString() ?? throw new CustomException("Немає ідентифікатора замовлення"),
                       infoRegClientBarcodes))
            {
                orderCreate.ShowDialog();

                if (orderCreate.DialogResult == DialogResult.OK)
                {
                }
            }
        }
    }
}
