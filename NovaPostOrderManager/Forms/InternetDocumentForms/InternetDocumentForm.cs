using ApplicationManager.Services;
using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.GetDocumentList;

namespace NovaPostOrderManager.Forms.InternetDocumentForms
{
    public partial class InternetDocumentForm : Form
    {
        //property save info
        private string _startDate;
        private string _endDate;
        private readonly InternetDocumentService _internetDocumentService;
        public InternetDocumentForm()
        {
            InitializeComponent();
            _internetDocumentService = new InternetDocumentService();
            _startDate = DTPStart.Value.ToString("dd.MM.yyyy");
            _endDate = DTPEnd.Value.ToString("dd.MM.yyyy");

            // Подписываемся на события изменения значения
            DTPStart.ValueChanged += DTPStart_ValueChanged;
            DTPEnd.ValueChanged += DTPEnd_ValueChanged;
            LoadGrid();
        }

        private async Task LoadGrid()
        {
            var response = await _internetDocumentService.GetDocumentList(new GetDocumentListProperty
            {
                DateTimeFrom = _startDate,
                DateTimeTo = _endDate,
                GetFullList = "0",
                Page = "1",
            });
            DataGridInternetDocument.DataSource = response.data;
            if (response.data.Count > 0)
                UpdateGridHeaders();
        }

        private void UpdateGridHeaders()
        {
            DataGridInternetDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridInternetDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Ref)]!.HeaderText = CoreDefaultValues.GetDocumentListDataRef;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.HeaderText = CoreDefaultValues.GetDocumentListDataDateTime;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PreferredDeliveryDate)]!.HeaderText = CoreDefaultValues.GetDocumentListDataPreferredDeliveryDate;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientDateTime)]!.HeaderText = CoreDefaultValues.GetDocumentListDataRecipientDateTime;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.EWDateCreated)]!.HeaderText = CoreDefaultValues.GetDocumentListDataEWDateCreated;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.HeaderText = CoreDefaultValues.GetDocumentListDataWeight;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SeatsAmount)]!.HeaderText = CoreDefaultValues.GetDocumentListDataSeatsAmount;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.HeaderText = CoreDefaultValues.GetDocumentListDataIntDocNumber;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.HeaderText = CoreDefaultValues.GetDocumentListDataCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CitySender)]!.HeaderText = CoreDefaultValues.GetDocumentListDataCitySender;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipient)]!.HeaderText = CoreDefaultValues.GetDocumentListDataCityRecipient;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddress)]!.HeaderText = CoreDefaultValues.GetDocumentListDataSenderAddress;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddress)]!.HeaderText = CoreDefaultValues.GetDocumentListDataRecipientAddress;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.HeaderText = CoreDefaultValues.GetDocumentListDataCostOnSite;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PayerType)]!.HeaderText = CoreDefaultValues.GetDocumentListDataPayerType;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PaymentMethod)]!.HeaderText = CoreDefaultValues.GetDocumentListDataPaymentMethod;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.HeaderText = CoreDefaultValues.GetDocumentListDataAfterpaymentOnGoodsCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PackingNumber)]!.HeaderText = CoreDefaultValues.GetDocumentListDataPackingNumber;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RejectionReason)]!.HeaderText = CoreDefaultValues.GetDocumentListDataRejectionReason;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateId)]!.HeaderText = CoreDefaultValues.GetDocumentListDataStateId;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.HeaderText = CoreDefaultValues.GetDocumentListDataStateName;

            foreach (DataGridViewColumn column in DataGridInternetDocument.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            DataGridInternetDocument.Columns[^1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
