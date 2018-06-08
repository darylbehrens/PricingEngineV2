using PricingEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine
{
    public abstract class PricingEngine<T>
    {
        public abstract IEnumerable<BilllableServiceBase> GetBillableServices(T t);
    }
}
