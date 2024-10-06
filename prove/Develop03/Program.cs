using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string referenceInput = "John 3:16"; // Example reference
        string textInput = "For God so loved the world that he gave his one and only Son"; // Example text

        Scripture scripture = new Scripture(referenceInput, textInput);
        scripture.Display();

        string userInput;
        do
        {
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWord();
                Console.Clear();
                scripture.Display();
            }

        } while (userInput != "quit");

        Console.WriteLine("Goodbye!");
    }
}
