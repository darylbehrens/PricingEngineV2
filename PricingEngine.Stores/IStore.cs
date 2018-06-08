using System.Collections.Generic;

namespace PricingEngine.Stores
{
    public interface IStore<I, O>
    {
        O FindFor(I i);
        
    }




}
