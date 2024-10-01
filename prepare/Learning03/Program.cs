using System;
// variables members are made private and can be accessible only through internal methods
// a general rule is that member variables should be private
//how to declare private member variables
// private string _title;

// methods: many methods should be public so they can access the private member variables
// how to declare public and private methods

// getters" and "setters help to access private variables

// contructors are special methods (a no-argument constructor / an argument constructor )
//


class Program
{
    static void Main(string[] args)
    {
        // Create a fraction using the constructor with no parameters (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");  // Output: 1/1
        Console.WriteLine($"Decimal value: {fraction1.GetDecimalValue()}"); // Output: 1.0

        // Create a fraction using the constructor with one parameter (6/1)
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");  // Output: 6/1
        Console.WriteLine($"Decimal value: {fraction2.GetDecimalValue()}"); // Output: 6.0

        // Create a fraction using the constructor with two parameters (6/7)
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");  // Output: 6/7
        Console.WriteLine($"Decimal value: {fraction3.GetDecimalValue()}"); // Output: ~0.857

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}




