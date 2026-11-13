using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Transport
{
    public class Car : ATransport
    {
        public Car(string type, bool statys, int maxWeight) : base(type, statys, maxWeight) { }

        public override double CalculateCost(Order order)
        {
            return 50 + (8 * order.Distance) + order.Weight;
        }
    }
}
