using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Transport
{
    public abstract class ATransport
    {
        public string Type { get; set; }
        public bool Statys { get; set; }
        public int MaxWeight { get; set; }

        protected ATransport(string type, bool statys, int maxWeight)
        {
            this.Type = type;
            this.Statys = statys;
            this.MaxWeight = maxWeight;
        }

        public abstract double CalculateCost(Order order);
        public virtual bool CanTake(Order order)
        {
            if (MaxWeight >= order.Weight)
                return true;

            return false;
        }
    }
}
