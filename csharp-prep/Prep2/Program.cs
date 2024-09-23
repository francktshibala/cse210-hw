using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string ValueFromUser = Console.ReadLine();
        int number = int.Parse(ValueFromUser);

        string letter = "";

        
        if ( number >= 90)
        {
            letter = "A";
        }

        else if ( number >= 80)
        {
            letter = "B";

        }

        else if ( number >= 70)
        {
            letter = "C";

        }

        else if ( number >= 60)
        {
            letter = "D";
        }


        else if ( number <= 50)
        {
            letter = "F";

        }

        Console.WriteLine($"Your grade is {letter}");


        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");

        }

        else if ( number <= 50)
        {
            Console.WriteLine("Sorry! You did not pass. Please try again.");
        }
    }
}