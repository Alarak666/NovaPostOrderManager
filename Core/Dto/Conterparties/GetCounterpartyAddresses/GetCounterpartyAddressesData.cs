namespace Core.Dto.Conterparties.GetCounterpartyAddresses
{
    public class GetCounterpartyAddressesData
    {
        public string Ref { get; set; }
        public string Description { get; set; }
        public string CityRef { get; set; }
        public string CityDescription { get; set; }
        public string StreetRef { get; set; }
        public string StreetDescription { get; set; }
        public string BuildingRef { get; set; }
        public string BuildingDescription { get; set; }
        public string Note { get; set; }
        public string AddressName { get; set; }
    }
}