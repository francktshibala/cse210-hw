using System;
using System.Collections.Generic;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the United States
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method to return a formatted address string
    public override string ToString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}