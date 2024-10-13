using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple St", "Toronto", "ON", "Canada");


        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);


        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget A", 101, 10.00, 2));
        order1.AddProduct(new Product("Widget B", 102, 15.50, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Gadget C", 201, 20.00, 1));
        order2.AddProduct(new Product("Gadget D", 202, 5.75, 3));


        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
        }
    }
}
