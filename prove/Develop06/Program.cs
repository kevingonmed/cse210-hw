using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class Program
    {
        private static List<Goal> goals = new List<Goal>();
        private static int totalPoints = 0;

        static void Main(string[] args)
        {
            LoadGoals();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1. View Goals");
                Console.WriteLine("2. Add Simple Goal");
                Console.WriteLine("3. Add Eternal Goal");
                Console.WriteLine("4. Add Checklist Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save and Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewGoals();
                        break;
                    case "2":
                        AddSimpleGoal();
                        break;
                    case "3":
                        AddEternalGoal();
                        break;
                    case "4":
                        AddChecklistGoal();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        SaveGoals();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private static void ViewGoals()
        {
            Console.WriteLine("\nYour Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetInfo());
            }
            Console.WriteLine($"Total Points: {totalPoints}");
        }

        private static void AddSimpleGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for this goal: ");
            int points = int.Parse(Console.ReadLine());
            goals.Add(new SimpleGoal(name, points));
        }

        private static void AddEternalGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for this goal: ");
            int points = int.Parse(Console.ReadLine());
            goals.Add(new EternalGoal(name, points));
        }

        private static void AddChecklistGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for each event: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter required times to complete: ");
            int requiredTimes = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, requiredTimes));
        }

        private static void RecordEvent()
        {
            Console.Write("Enter the number of the goal to record: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < goals.Count)
            {
                goals[index].RecordEvent();
                totalPoints += goals[index].GetPoints();
                Console.WriteLine("Event recorded!");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        private static void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.GetInfo());
                }
                writer.WriteLine($"Total Points: {totalPoints}");
            }
            Console.WriteLine("Goals saved!");
        }

        private static void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine(line); // Display loaded goals
                    // You can implement loading logic here if needed
                }
            }
        }
    }
}
