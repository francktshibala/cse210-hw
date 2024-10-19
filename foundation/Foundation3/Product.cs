// Product class to store product details
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to get the total cost of the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Method to get the product name
    public string GetName()
    {
        return _name;
    }

    // Method to get the product ID
    public string GetProductId()
    {
        return _productId;
    }
}
