using ApplicationManager.Services;
using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.GetDocumentList;
using System.Windows.Forms;
using Core.Constants.Enums;
using ApplicationManager.Helpers;

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
            
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.IntDocNumber)]!.HeaderText = CoreDefaultValues.GetInternetDocumentIntDocNumber;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.InfoRegClientBarcodes)]!.HeaderText = CoreDefaultValues.GetInternetDocumentInfoRegClientBarcodes;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.StateName)]!.HeaderText = CoreDefaultValues.GetInternetDocumentStateName;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.DateTime)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDateTime;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Cost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CostOnSite)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCostOnSite;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Weight)]!.HeaderText = CoreDefaultValues.GetInternetDocumentWeight;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.Description)]!.HeaderText = CoreDefaultValues.GetInternetDocumentDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SenderAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSenderAddressDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.SendersPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentSendersPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.AfterpaymentOnGoodsCost)]!.HeaderText = CoreDefaultValues.GetInternetDocumentAfterpaymentOnGoodsCost;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PaymentMethod)]!.HeaderText = CoreDefaultValues.GetInternetDocumentPaymentMethod;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientContactPerson)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientContactPerson;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientsPhone)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientsPhone;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.CityRecipientDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentCityRecipientDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.RecipientAddressDescription)]!.HeaderText = CoreDefaultValues.GetInternetDocumentRecipientAddressDescription;
            DataGridInternetDocument.Columns[nameof(GetDocumentListData.PayerType)]!.HeaderText = CoreDefaultValues.GetInternetDocumentPayerType;
           
            foreach (DataGridViewColumn column in DataGridInternetDocument.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
            DataGridInternetDocument.CellFormatting += dataGridView1_CellFormatting;

        }
        private void dataGridView1_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is DataGridView dataGridView && e.Value is PayerType type)
            {
                // Сравниваем имя столбца с ожидаемым
                string? columnName = dataGridView.Columns[nameof(GetDocumentListData.PayerType)]?.Name;
                if (columnName == nameof(GetDocumentListData.PayerType))
                {
                    e.Value = ComponentHelper.GetEnumDescription(type);
                }
            }
            if (sender is DataGridView dataGridView1 && e.Value is PaymentMethod paymentMethod)
            {
                // Сравниваем имя столбца с ожидаемым
                string? columnName = dataGridView1.Columns[nameof(GetDocumentListData.PaymentMethod)]?.Name;
                if (columnName == nameof(GetDocumentListData.PaymentMethod))
                {
                    e.Value = ComponentHelper.GetEnumDescription(paymentMethod);
                }
            }
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
