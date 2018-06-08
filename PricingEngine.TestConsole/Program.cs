using PricingEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var prium = new Entity<Review>();
            var review = new Review(prium);

            // Setup Customer Store For Test
            var customerData = new CustomerData();
            customerData.Add(review);
            var customerStore = new LocalCustomerStore(customerData);



            // Setup Local Store For Test
            var services = new List<BilllableServiceBase>() { new InitialPeerReview() };
            var serviceData = new BillableServiceData(review, services);
            var serviceStore = new BillableServiceLocalStore(serviceData);
            var pricingEngine = new PriumPricingEngine(customerStore, serviceStore);

            var result = pricingEngine.GetBillableServices(review);
            
        }
    }
}
