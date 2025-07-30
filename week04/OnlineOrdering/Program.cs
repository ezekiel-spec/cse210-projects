using System;

class Program
{
    static void Main(string[] args)
    {
        // First order
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Cable", "USB123", 5.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "MSE456", 15.50, 1));

        // Second order
        Address address2 = new Address("88 High Street", "London", "England", "UK");
        Customer customer2 = new Customer("John Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB789", 3.99, 3));
        order2.AddProduct(new Product("Pen Set", "PN321", 2.50, 2));

        // Display order summaries
        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}