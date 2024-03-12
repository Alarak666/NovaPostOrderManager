using Core.Dto.Base;

namespace Core.Dto.Conterparties.CreateCounterparties
{
    public class CreateCounterpartyData
    {
        public string Ref { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Counterparty { get; set; }
        public string OwnershipForm { get; set; }
        public string OwnershipFormDescription { get; set; }
        public string EDRPOU { get; set; }
        public string CounterpartyType { get; set; }
        public BaseResponse<ContactPerson>? ContactPerson { get; set; }
    }
}