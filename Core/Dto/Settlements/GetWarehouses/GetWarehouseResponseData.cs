namespace Core.Dto.Settlements.GetWarehouses;

public class GetWarehouseResponseData
{
    public string SiteKey { get; set; }
    public string Description { get; set; }
    public string DescriptionRu { get; set; }
    public string ShortAddress { get; set; }
    public string ShortAddressRu { get; set; }
    public string Phone { get; set; }
    public string TypeOfWarehouse { get; set; }
    public string Ref { get; set; }
    public string Number { get; set; }
    public string CityRef { get; set; }
    public string CityDescription { get; set; }
    public string CityDescriptionRu { get; set; }
    public string SettlementRef { get; set; }
    public string SettlementDescription { get; set; }
    public string SettlementAreaDescription { get; set; }
    public string SettlementRegionsDescription { get; set; }
    public string SettlementTypeDescription { get; set; }
    public string SettlementTypeDescriptionRu { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public string PostFinance { get; set; }
    public string BicycleParking { get; set; }
    public string PaymentAccess { get; set; }
    public string POSTerminal { get; set; }
    public string InternationalShipping { get; set; }
    public string SelfServiceWorkplacesCount { get; set; }
    public string TotalMaxWeightAllowed { get; set; }
    public string PlaceMaxWeightAllowed { get; set; }
    public Dimension SendingLimitationsOnDimensions { get; set; }
    public Dimension ReceivingLimitationsOnDimensions { get; set; }
    public Dictionary<string, string> Reception { get; set; }
    public Dictionary<string, string> Delivery { get; set; }
    public Dictionary<string, string> Schedule { get; set; }
    public string DistrictCode { get; set; }
    public string WarehouseStatus { get; set; }
    public string WarehouseStatusDate { get; set; }
    public string WarehouseIllusha { get; set; }
    public string CategoryOfWarehouse { get; set; }
    public string Direct { get; set; }
    public string RegionCity { get; set; }
    public string WarehouseForAgent { get; set; }
    public string GeneratorEnabled { get; set; }
    public string MaxDeclaredCost { get; set; }
    public string WorkInMobileAwis { get; set; }
    public string DenyToSelect { get; set; }
    public string CanGetMoneyTransfer { get; set; }
    public string HasMirror { get; set; }
    public string HasFittingRoom { get; set; }
    public string OnlyReceivingParcel { get; set; }
    public string PostMachineType { get; set; }
    public string PostalCodeUA { get; set; }
    public string WarehouseIndex { get; set; }
    public string BeaconCode { get; set; }
}