using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Policies.Gender
{
    internal class MailGenderPolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData policyData) => new List<PackingItem>()
        {
            new ("Laptop", 1),
            new ("Beer", 10),
            new ("Book", (uint)Math.Ceiling(policyData.TravelDays /7m)),
        };
     

        public bool IsAppLicable(PolicyData policyData)
        => policyData.Gender is Const.Gender.Male;


        
    }
}
