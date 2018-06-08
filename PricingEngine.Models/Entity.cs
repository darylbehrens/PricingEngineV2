using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngine.Models
{
    public class Entity<T>
    {
        public Guid EntityId { get; set; }

        public override bool Equals(object obj)
        {
            var entity = obj as Entity<T>;
            
            return entity != null &&
                   EntityId.Equals(entity.EntityId);
        }

        public override int GetHashCode()
        {
            return -1619204625 + EqualityComparer<Guid>.Default.GetHashCode(EntityId);
        }
    }
}
