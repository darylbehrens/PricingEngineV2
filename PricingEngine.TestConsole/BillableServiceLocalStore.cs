using System;
using System.Collections.Generic;
using PricingEngine.Models;
using PricingEngine.Stores;

namespace PricingEngine.TestConsole
{
    public class BillableServiceLocalStore : LocalStore<BillableItemBase, IEnumerable<BilllableServiceBase>>
    {
        public BillableServiceLocalStore(Dictionary<BillableItemBase, IEnumerable<BilllableServiceBase>> data) : base(data)
        {
        }
    }

    public class BillableServiceData : Dictionary<BillableItemBase, IEnumerable<BilllableServiceBase>>
    {
        public BillableServiceData(BillableItemBase key, IEnumerable<BilllableServiceBase> value)
        {
            Add(key, value);
        }
    }

}
