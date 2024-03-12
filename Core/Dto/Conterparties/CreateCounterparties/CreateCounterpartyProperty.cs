using Newtonsoft.Json;

namespace Core.Dto.Conterparties.CreateCounterparties;

public class CreateCounterpartyProperty
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string CounterpartyType { get; set; }
    public string CounterpartyProperty { get; set; }
}