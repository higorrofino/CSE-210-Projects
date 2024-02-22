using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order 1:");
        Order o1 = new Order();
        Customer c1 = new Customer("John", "Burton");
        Address a1 = new Address("Street 1", "Salt Lake", "Utah", "USA");
        Product p1 = new Product("pencil", "1234", 1.6f, 3);
        Product p11 = new Product("pen", "34567", 2.1f, 10);
        o1._prod.Add(p1);
        o1._prod.Add(p11);
        o1.PackingLabel();
        Console.WriteLine("-------------------------------");
        o1.ShippingLabel(c1.FullName(),a1.FullAddress());
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"The total amount of this order is ${o1.OrderAmt()}");
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine("Order 2:");
        Order o2 = new Order();
        Customer c2 = new Customer("John", "Burton");
        Address a2 = new Address("Street 1", "Salt Lake", "Utah", "USA");
        Product p2 = new Product("sharpener", "213431", 1f, 20);
        Product p22 = new Product("rubber", "987678", 0.3f, 7);
        o1._prod.Add(p2);
        o1._prod.Add(p22);
        o1.PackingLabel();
        Console.WriteLine("-------------------------------");
        o1.ShippingLabel(c1.FullName(),a1.FullAddress());
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"The total amount of this order is ${o1.OrderAmt()}");
        Console.WriteLine("-------------------------------");
    }
}