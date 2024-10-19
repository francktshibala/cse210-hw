// Order class to store order details
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on whether the customer lives in the USA
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}