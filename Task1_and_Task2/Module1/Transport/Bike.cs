using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Transport
{
    public class Bike : ATransport
    {
        public readonly int _maxDistance = 10;

        public Bike(string type, bool statys, int maxWeight) : base(type, statys, maxWeight) { }

        public override double CalculateCost(Order order)
        {
            return 20 + (5 * order.Distance);
        }

        public override bool CanTake(Order order)
        {
            if (MaxWeight >= order.Weight && _maxDistance >= order.Distance)
                return true;

            return false;
        }
    }
}
