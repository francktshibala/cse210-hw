using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customers with addresses
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Maple Rd", "Toronto", "ON", "Canada"));

        // Create orders for each customer
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Create products and add them to the orders
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 19.99, 2));

        order2.AddProduct(new Product("Desk", "C789", 299.99, 1));
        order2.AddProduct(new Product("Chair", "D012", 89.99, 4));

        // Display packing and shipping labels and total cost for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display packing and shipping labels and total cost for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
    