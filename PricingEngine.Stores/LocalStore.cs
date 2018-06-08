using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine.Stores
{
    public abstract class LocalStore<I,O> : IStore<I, O>
    {
        protected Dictionary<I, O> Store;

        public LocalStore(Dictionary<I, O> data)
        {
            Store = data;
        }

        public virtual O FindFor(I i)
        {
            return Store[i];
        }
    }
}
