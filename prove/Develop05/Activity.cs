using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _activityName;
    private string _description;
    protected int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting: {_activityName}");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You've completed the {_activityName} for {_duration} seconds.");
        DisplayMotivationalQuote();
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    public abstract void Run();

    private void DisplayMotivationalQuote()
    {
        var quotes = new List<string>
        {
            "Keep going! You're doing great!",
            "Believe you can and you're halfway there.",
            "Your only limit is you.",
            "You are stronger than you think."
        };

        Random random = new Random();
        Console.WriteLine(quotes[random.Next(quotes.Count)]);
    }
}
