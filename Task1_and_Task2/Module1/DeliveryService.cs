using Module1.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1
{
    public class DeliveryService
    {
        private List<ATransport> _transports = new();
        private List<Order> _ordersActive = new();
        private List<Order> _ordersHistory = new();

        public void AddTransport(ATransport transport)
        {
            _transports.Add(transport);
        }

        public void AddOrder(Order order)
        {
            _ordersActive.Add(order);
        }

        public void GetCostDelivery(Order order)
        {
            foreach (ATransport t in _transports)
            {
                if (t.CanTake(order))
                    Console.WriteLine($"{t.Type} доставить замовлення {order.Id} за: {t.CalculateCost(order)} грн");
            }
        }

        public void AssingOrder(ATransport transport, Order order)
        {
            if (transport.Statys == false)
            {
                if (transport.CanTake(order))
                {
                    Console.WriteLine($"{transport.Type} взяв замовлення номер: {order.Id}");
                    transport.Statys = true;
                    //_ordersActive.Add(order);
                    order.AssignedTransport = transport;
                    return;
                }
            }

            Console.WriteLine($"{transport.Type} не може взяти: {order.Id}");
        }

        public void Deliver(Order order, bool paymentMethod)
        {
            Console.WriteLine($"Замовлення доставлено та оплачено {(paymentMethod ? "Карта" : "Готівка")}");

            _ordersActive.Remove(order);
            _ordersHistory.Add(order);

            if (order.AssignedTransport != null)
                order.AssignedTransport.Statys = false;
        }

        public void GetInfoOrderActive()
        {
            Console.WriteLine("OrderActive");

            foreach (Order o in _ordersActive)
            {
                Console.WriteLine($"Замовлення {o.Id}, вага: {o.Weight}кг, відстань:{o.Distance}, опис: {o.Description}");
            }
        }

        public void GetInfoOrderHistory()
        {
            Console.WriteLine("OrderHistory");

            foreach (Order o in _ordersHistory)
            {
                Console.WriteLine($"Замовлення {o.Id}, вага: {o.Weight}кг, відстань:{o.Distance},  опис: {o.Description}");
            }
        }

        public void GetInfoTransport()
        {
            Console.WriteLine("Transport");

            foreach (ATransport t in _transports)
            {
                Console.WriteLine($"Транспорт {t.Type}, статус: {(t.Statys ? "зайнятий" : "вільний")}, ваксимальне навантаження: {t.MaxWeight}кг");
            }
        }
    }
}
