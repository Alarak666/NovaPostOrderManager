using ApplicationManager.Services;

namespace NovaPostOrderManager.Forms.Address
{
    public partial class SearchSettlement : Form
    {
        public SearchSettlement()
        {
            InitializeComponent();
        }

        private async Task LoadGrid(string cityName)
        {
            var searchSettlementService = new SearchSettlementService();
            var response = await searchSettlementService.GetCityData(cityName);
            DataGridOrder.DataSource = response.data[0].Addresses;
        }

        private void DataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await LoadGrid(textBox1.Text);
        }
    }
}
