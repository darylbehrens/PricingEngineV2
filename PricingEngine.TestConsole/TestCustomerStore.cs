using PricingEngine.Models;
using System.Collections.Generic;
using System;
using PricingEngine.Stores;

namespace PricingEngine.TestConsole
{
    public class LocalCustomerStore : LocalStore<Guid, Entity<BillableItemBase>>
    {
        public LocalCustomerStore(CustomerData store) : base(store)
        {
        }
    }

    public sealed class CustomerData : Dictionary<Guid, Entity<BillableItemBase>>
    {
        public void Add(BillableItemBase item)
        {
            Add(item.Owner.EntityId, new Prium());
        }
    }
}
