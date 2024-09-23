using System;

class Program
{
    static void Main(string[] args)
    {
        
       
        // int number = 10;
        int ResponseNumber = 0;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is the magic number? ");
        ResponseNumber = int.Parse(Console.ReadLine());
                
    
        while (ResponseNumber != magicNumber)

            
        {
            if (ResponseNumber > magicNumber)
            {
                Console.WriteLine(" Guess lower");
            }


            else if (ResponseNumber < magicNumber)
            {
                Console.WriteLine(" Guess higher");
            }

            
            Console.Write("What is the magic number? ");
            ResponseNumber = int.Parse(Console.ReadLine());
        
        }

        Console.WriteLine(" You Guess It.");
    }
}