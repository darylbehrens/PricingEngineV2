using System.Collections.Generic;

namespace PricingEngine.Stores
{
    public abstract class SqlStore<I,O> : IStore<I,O>
    {
        private readonly string ConnectionString;

        public SqlStore(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public abstract O FindFor(I i);
    }

}
