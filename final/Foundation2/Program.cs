using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _products = new List<Product>();
        Console.Clear();
        Console.WriteLine("Program 2: Encapsulation with Online Ordering.");
        Console.WriteLine();

        // Create some products
        Product product1 = new Product("T-Shirt", 1234, 19.99m, 2, _products);
        Product product2 = new Product("Jeans", 5678, 49.99m, 1, _products);
        Product product3 = new Product("Coverall", 765, 59.99m, 1, _products);

        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 High St", "Somewhere", "ON", "Canada");
        Address address3 = new Address("Colonia Lomas de zamora", "Tuxtla", "MX", "Mexico");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Juan Perez", address3);

        // Create some orders, note how we clear the list for each order.
        // The program specification doesn't ask to iterate through so I decided to do it this way without a for loop.
        Order order1 = new Order(customer1, _products,"USA");
        order1._products.Add(product1);
        order1._products.Add(product2);
        Console.WriteLine("Order 1");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine(product1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(customer1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}");
        _products.Clear();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        Order order2 = new Order(customer2, _products,"CANADA");
        order2._products.Add(product1);
        order2._products.Add(product3);
        Console.WriteLine("Order 2");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine(product2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(customer2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}");
        _products.Clear();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();

        Order order3 = new Order(customer3, _products,"MEXICO");
        order3._products.Add(product3);
        order3._products.Add(product2);
        Console.WriteLine("Order 3");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine(product3.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(customer3.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order3.CalculateTotalCost()}");
        _products.Clear();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine();
    }
}