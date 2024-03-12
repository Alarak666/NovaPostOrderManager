using System.ComponentModel;

namespace Core.Constants.Enums;

public enum ServiceType
{
    [Description("Від двері - до двері")]
    DoorsDoors,

    [Description("Від двері- до склада")]
    DoorsWarehouse,

    [Description("Від склада - до склада")]
    WarehouseWarehouse,

    [Description("Від склада - до двері")]
    WarehouseDoors
}