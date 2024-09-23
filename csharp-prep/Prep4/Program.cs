
        // Console.WriteLine("Hello Prep4 World!");
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // add item to the list

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        //Getting the list size
        // Console.WriteLine(words.Count);

        // iteration list: the easiest way
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // continue getting numbers from a user and stop when o is  entered
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        
        // compute sum, average, and maximum
        if (numbers.Count > 0)
        {
            
            int sum = numbers.Sum();
           
            double average = numbers.Average();
            
            int maxNumber = numbers.Max();
            
            // Show the results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        
    }
}



        


        

   