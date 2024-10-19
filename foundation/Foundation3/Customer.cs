// Customer class to store customer details
class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the United States
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get customer name
    public string GetName()
    {
        return _name;
    }

    // Method to get customer address
    public string GetAddress()
    {
        return _address.ToString();
    }
}
