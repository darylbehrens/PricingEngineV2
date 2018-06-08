using PricingEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine.UnitTests
{
    public static class Helpers
    {
        public static LocalCustomerStore GetCustomerStore()
        {
            return new LocalCustomerStore(GetCustomerData());
        }


        public static CustomerData GetCustomerData()
        {
            return new CustomerData().Add(GetReview());
        }

        public static UtilizationReview GetReview()
        {
            return new UtilizationReview(GetCustomer());
        }

        public static Entity<BillableItemBase> GetCustomer()
        {
            return new Entity<BillableItemBase>();
        }
    }
}
