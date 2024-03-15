using ApplicationManager.Services.DataBaseService;
using ApplicationManager.Services.NovaPostService;
using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.GetDocumentList;
using System.Data;

namespace NovaPostOrderManager.Forms.InternetDocumentForms
{
    public partial class InternetDocumentForm : Form
    {
        //property save info
        private string _startDate;
        private string _endDate;
        private readonly InternetDocumentService _internetDocumentService;
        private readonly InternetDocumentDataBaseService _internetDocumentDataBaseService;

        public InternetDocumentForm()
        {
            InitializeComponent();
            _internetDocumentService = new InternetDocumentService();
            _internetDocumentDataBaseService = new InternetDocumentDataBaseService();
            _startDate = DTPStart.Value.ToString("dd.MM.yyyy");
            _endDate = DTPEnd.Value.ToString("dd.MM.yyyy");

            // Подписываемся на события изменения значения
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            LoadGrid();
        }

        private async Task LoadGrid()
        {
            var dataApteka = await _internetDocumentDataBaseService.GetApteka();
            var prefix = dataApteka.Rows[0]["prefix"]?.ToString() ?? "100";
            var response = await _internetDocumentService.GetDocumentList(new GetDocumentListProperty
            {
                DateTimeFrom = _startDate,
                DateTimeTo = _endDate,
                GetFullList = "0",
                Page = "1",
            });

            DataGridInternetDocument.DataSource = response.data.Where(x => prefix != null && x.InfoRegClientBarcodes.StartsWith(prefix)).ToList();
            if (response.data.Count > 0)
            {
                UpdateGridHeaders();
                SetColumnIndex();
            }
        }

        private void SetColumnIndex()
        {
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.DisplayIndex = 0;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.DisplayIndex = 1;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.DisplayIndex = 2;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.DisplayIndex = 3;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.DisplayIndex = 4;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.DisplayIndex = 5;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.DisplayIndex = 6;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.DisplayIndex = 7;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Description)]!.DisplayIndex = 8;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderContactPerson)]!.DisplayIndex = 9;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddressDescription)]!.DisplayIndex = 10;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SendersPhone)]!.DisplayIndex = 11;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientContactPerson)]!.DisplayIndex = 12;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientsPhone)]!.DisplayIndex = 13;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipientDescription)]!.DisplayIndex = 14;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddressDescription)]!.DisplayIndex = 15;
        }

        private void UpdateGridHeaders()
        {
            DataGridInternetDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridInternetDocument.ScrollBars = ScrollBars.Both;

            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.HeaderText = CoreDefaultValues.GetInternetDocumentIntDocNumber;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.HeaderText = CoreDefaultValues.GetInternetDocumentStateName;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.HeaderText = CoreDefaultValues.GetInternetDocumentInfoRegClientBarcodes;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDateTime;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCostOnSite;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.HeaderText = CoreDefaultValues.GetInternetDocumentWeight;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Description)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderAddressDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SendersPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSendersPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentAfterpaymentOnGoodsCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientsPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientsPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipientDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCityRecipientDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientAddressDescription;
            //HideField
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.Visible = false;
        }

        private void DTPStart_ValueChanged(object? sender, EventArgs e)
        {
            _startDate = DTPStart.Value.ToString("dd.MM.yyyy");
        }

        private void DTPEnd_ValueChanged(object? sender, EventArgs e)
        {
            _endDate = DTPEnd.Value.ToString("dd.MM.yyyy");
        }

        private async void BLoad_Click(object sender, EventArgs e)
        {
            await LoadGrid();
        }
    }
}
