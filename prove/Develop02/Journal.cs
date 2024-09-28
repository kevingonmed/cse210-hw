using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> entries;
    private Random random;
    private string[] prompts;

    public Journal()
    {
        entries = new List<JournalEntry>();
        random = new Random();
        prompts = new string[]
        {
            "What was the best part of my day?",
            "Who was the most interesting person I met today?",
            "How did I feel today?",
            "What is one thing I learned today?",
            "What am I grateful for today?"
        };
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveToFile();
                    break;
                case "4":
                    LoadFromFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void WriteEntry()
    {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        JournalEntry newEntry = new JournalEntry(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new JournalEntry(parts[1].Trim(), parts[2].Trim()) { Date = parts[0].Trim() });
            }
        }
    }
}
