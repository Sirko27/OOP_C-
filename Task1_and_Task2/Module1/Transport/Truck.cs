using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Transport
{
    public class Truck : ATransport
    {
        public Truck(string type, bool statys, int maxWeight) : base(type, statys, maxWeight) { }

        public override double CalculateCost(Order order)
        {
            return 200 + (15 * order.Distance) + (0.5 * order.Weight);
        }
    }
}
