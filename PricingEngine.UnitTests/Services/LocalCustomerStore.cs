using PricingEngine.Models;
using PricingEngine.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine.UnitTests
{
    public class LocalCustomerStore : LocalStore<Guid, Entity<BillableItemBase>>
    {
        public LocalCustomerStore(CustomerData data) : base(data)
        {
        }
    }
    public sealed class CustomerData : Dictionary<Guid, Entity<BillableItemBase>>
    {
        public CustomerData Add(BillableItemBase item)
        {
            return new CustomerData().Add(item);
        }

       
    }
}


