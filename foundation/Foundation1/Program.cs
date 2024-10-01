using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        // Person p = new Person();
        // p.SetFirstName("Peter");
        // Console.WriteLine(p.GetFirstName());

        Person p1 = new Person(); // Don't pass any information to get the default values
        Person p2 = new Person("Jane", "Doe"); // pass the first and last names
        Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables
        
    }
}