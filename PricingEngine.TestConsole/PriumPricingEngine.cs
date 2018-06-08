using PricingEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PricingEngine.TestConsole
{
    public class PriumPricingEngine : PricingEngine<BillableItemBase>
    {
        public PriumPricingEngine(LocalCustomerStore customerStore, BillableServiceLocalStore serviceStore)
        {
            CustomerStore = customerStore;
            BillableServiceStore = serviceStore;
        }

        private LocalCustomerStore CustomerStore { get; }
        private BillableServiceLocalStore BillableServiceStore { get; }

        public override IEnumerable<BilllableServiceBase> GetBillableServices(BillableItemBase item)
        {
            return BillableServiceStore.FindFor(item);
        }
    }
}
