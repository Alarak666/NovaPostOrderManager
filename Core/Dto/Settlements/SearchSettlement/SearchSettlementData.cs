namespace Core.Dto.Settlements.SearchSettlement
{
    public class SearchSettlementData
    {
        public int TotalCount { get; set; }
        public List<SearchSettlementAddress> Addresses { get; set; }
        public string Warehouses { get; set; }
        public string MainDescription { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string SettlementTypeCode { get; set; }
        public string Ref { get; set; }
        public string DeliveryCity { get; set; }
    }
}

