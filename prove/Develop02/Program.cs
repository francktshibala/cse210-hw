using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal
        Journal myJournal = new Journal();
        myJournal._ownerName = "Franck Tshibala";  // Set the journal owner's name

        bool running = true;
        while (running)
        {
            // Display menu options
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            // Handle user's menu choice
            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();  // Add a new entry
                    break;
                case "2":
                    myJournal.Display();   // Display all entries
                    break;
                case "3":
                    myJournal.SaveToFile();  // Save the journal to a file
                    break;
                case "4":
                    myJournal.LoadFromFile();  // Load the journal from a file
                    break;
                case "5":
                    running = false;  // Exit the program
                    Console.WriteLine("Exiting the journal.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                    break;
            }
        }
    }
}