using System.Text.RegularExpressions;
using ApplicationManager.Services;
using Core.Constants.Enums;
using Core.Dto.InternetDocument;
using Core.Dto.InternetDocument.Request;

namespace NovaPostOrderManager.Forms.OrderForms
{
    public partial class OrderCreate : Form
    {
        private readonly InternetDocumentProperty _internetDocumentProperty;
        private readonly OrderPostService _orderPostService;

        public  OrderCreate(InternetDocumentProperty internetDocumentProperty, OrderPostService orderPostService)
        {
            _internetDocumentProperty = internetDocumentProperty;
            _orderPostService = orderPostService;
            InitializeComponent();
            InitializeField();
            LoadField();
        }

        private async Task LoadField()
        {

        }

        private async Task InitializeField()
        {
            var paymentMethods = Enum.GetValues(typeof(PaymentMethod)).Cast<PaymentMethod>().ToList();
            CbPaymentMethod.DataSource = paymentMethods;

            var payerType = Enum.GetValues(typeof(PayerType)).Cast<PayerType>().ToList();
            CbPayerType.DataSource = payerType;

            var serviceType = Enum.GetValues(typeof(ServiceType)).Cast<ServiceType>().ToList();
            CbServiceType.DataSource = serviceType;

            DtpDateTime.Value = DateTime.Now;

            var responseAddressSender =await _orderPostService.GetAddress(_internetDocumentProperty.CityRecipient,
                _internetDocumentProperty.RecipientAddress);
            var responseAddressRecipient =
                await _orderPostService.GetAddress("Київ", warehouseId: "3132");

            TSenderWarehouseIndex.Text = responseAddressSender.data[0].WarehouseIndex;
            TCitySender.Text = responseAddressSender.data[0].SettlementRef;
            TSenderAddress.Text = responseAddressSender.data[0].Ref;
            TSendersPhone.Text = "+380973848153";

            TRecipientWarehouseIndex.Text = responseAddressRecipient.data[0].WarehouseIndex;
            TCityRecipient.Text = responseAddressRecipient.data[0].SettlementRef;
            TRecipientAddress.Text = responseAddressRecipient.data[0].Ref;
            TRecipientsPhone.Text = FormatPhoneNumber(_internetDocumentProperty.RecipientsPhone);

            string[] parts = _internetDocumentProperty.Recipient.Split(' ');

            string lastName = parts[0]; // Фамилия
            string firstName = parts[1]; // Имя
            string middleName = parts[2]; // Отчество

        }

        public string FormatPhoneNumber(string phoneNumber)
        {
            // Извлекаем только цифры из строки
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            // Добавляем префикс "+38" к оставшимся цифрам
            return $"+38{digitsOnly.Substring(2)}";
        }
    }
}
