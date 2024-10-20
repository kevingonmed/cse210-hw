using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        AddCustomPrompt();
    }

    private void AddCustomPrompt()
    {
        Console.Write("Would you like to add a custom prompt? (yes/no): ");
        if (Console.ReadLine().ToLower() == "yes")
        {
            Console.Write("Enter your custom prompt: ");
            string customPrompt = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(customPrompt))
            {
                prompts.Add(customPrompt);
                Console.WriteLine("Custom prompt added!");
            }
        }
    }

    public override void Run()
    {
        StartActivity();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(5);

        Console.WriteLine("Start listing items (press Enter after each item). You have " + _duration + " seconds.");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
