using ApplicationManager.Services;

namespace NovaPostOrderManager.Forms
{
    public partial class SearchSettlement : Form
    {
        public SearchSettlement()
        {
            InitializeComponent();
            LoadGrid();
        }

        private async void LoadGrid()
        {
            var searchSettlementService = new SearchSettlementService();
            var response =await searchSettlementService.GetCityData("Київ");
            DataGridOrder.DataSource = response.data[0].Addresses;
        }

        private void DataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
