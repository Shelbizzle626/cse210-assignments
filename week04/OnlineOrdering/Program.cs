using System;
using System.Collections.Generic;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("59 Magnesium St", "Henderson", "NV", "USA");
        Customer customer1 = new Customer("Les Zike", addr1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Fidget Spinner", "4325", 9.99f, 2));
        order1.AddProduct(new Product("Wrench", "3242", 15.89f, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Address addr2 = new Address("1543 Gentile St", "Layton", "UT", "USA");
        Customer customer2 = new Customer("April Hill", addr2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Sneakers", "8765", 59.99f, 1));
        order2.AddProduct(new Product("Nail Polish", "453", 8.99f, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");

        Address addr3 = new Address("389 Cookie Ln", "Stuttgart", "Stuttgart","Germany");
        Customer customer3 = new Customer("Dafina Zike", addr3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Birkenstock", "6754", 120.99f, 1));
        order3.AddProduct(new Product("Diapers", "4536", 45.99f, 1));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}\n");
    }
}