using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.Conterparties.GetCounterparties
{
    public class GetCounterpartyData
    {
        public string Description { get; set; }
        public string Ref { get; set; }
        public string City { get; set; }
        public string Counterparty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string OwnershipFormRef { get; set; }
        public string OwnershipFormDescription { get; set; }
        public string EDRPOU { get; set; }
        public string CounterpartyType { get; set; }
    }
}
