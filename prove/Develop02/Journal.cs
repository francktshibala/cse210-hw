using System;
using System.Collections.Generic;
using System.IO;  // For file handling

// Class representing a single journal entry
public class JournalEntry
{
    // Member variables
    public string _prompt;
    public string _response;
    public string _date;

    // Method to display the journal entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }

    // Method to convert journal entry to a string for saving to a file
    public string ToFileString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    // Method to load a journal entry from a string
    public static JournalEntry FromFileString(string fileString)
    {
        string[] parts = fileString.Split("~|~");
        if (parts.Length == 3)
        {
            return new JournalEntry
            {
                _date = parts[0],
                _prompt = parts[1],
                _response = parts[2]
            };
        }
        return null;
    }
}

// Class representing the entire journal
public class Journal
{
    // Member variables
    public string _ownerName;
    public List<JournalEntry> _entries = new List<JournalEntry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Method to add a new entry to the journal
    public void AddEntry()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {randomPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        // Create a new journal entry instance
        JournalEntry entry = new JournalEntry
        {
            _prompt = randomPrompt,
            _response = response,
            _date = date
        };

        // Add the entry to the list of journal entries
        _entries.Add(entry);
        Console.WriteLine("Entry added successfully.\n");
    }

    // Method to display all entries in the journal
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        Console.WriteLine($"Journal Owner: {_ownerName}");
        Console.WriteLine("Journal Entries:\n");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();  // Display each entry
        }
    }

    // Method to save the journal to a file
    public void SaveToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine($"Journal saved to {filename}\n");
    }

    // Method to load the journal from a file
    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear();  // Clear current entries before loading

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                JournalEntry entry = JournalEntry.FromFileString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {filename}\n");
        }
        else
        {
            Console.WriteLine("File not found!\n");
        }
    }
}