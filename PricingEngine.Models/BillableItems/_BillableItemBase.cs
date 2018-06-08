using System;
using System.Collections.Generic;

namespace PricingEngine.Models
{
    public abstract class BillableItemBase
    {

        public BillableItemBase(Entity<BillableItemBase> owner)
        {
            Owner = owner;
        }

        public Entity<BillableItemBase> Owner { get; }

        public override bool Equals(object obj)
        {
            var item = obj as BillableItemBase;
            return item != null &&
            this.GetType() == item.GetType() &&
            this.Owner == item.Owner;
        }

        public override int GetHashCode()
        {
            return 1649476756 + EqualityComparer<Entity<BillableItemBase>>.Default.GetHashCode(Owner);
        }
    }
    
}