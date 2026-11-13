using Module1;
using Module1.Transport;

DeliveryService DS = new DeliveryService();

Bike bike = new Bike("Bike", false, 10);
Car car = new Car("Car", false, 200);
Truck truck = new Truck("Truck", false, 3500);

Order order1 = new Order(1, 25, 5, "");
Order order2 = new Order(2, 60000, 50, "");
Order order3 = new Order(3, 1, 1, "");
Order order4 = new Order(4, 120, 1, "");

DS.AddTransport(bike);
DS.AddTransport(car);
DS.AddTransport(truck);

DS.AddOrder(order1);
DS.AddOrder(order2);
DS.AddOrder(order3);
DS.AddOrder(order4);

DS.GetInfoTransport();
Console.WriteLine();
DS.GetInfoOrderActive();
Console.WriteLine();

DS.GetCostDelivery(order1);
DS.GetCostDelivery(order2);
DS.GetCostDelivery(order3);
DS.GetCostDelivery(order4);
Console.WriteLine();

DS.AssingOrder(bike, order4);
DS.AssingOrder(bike, order1);
DS.AssingOrder(bike, order3);
DS.AssingOrder(car, order4);
DS.AssingOrder(car, order2);
Console.WriteLine();

DS.GetInfoTransport();
Console.WriteLine();

DS.Deliver(order4, true);
DS.Deliver(order3, false);
Console.WriteLine();

DS.GetInfoOrderActive();
DS.GetInfoOrderHistory();
Console.WriteLine();