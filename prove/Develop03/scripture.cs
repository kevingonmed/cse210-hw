using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    // Constructor for a single verse
    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Constructor for a verse range
    public Scripture(string reference, List<string> texts)
    {
        Reference = new Reference(reference);
        Words = texts.SelectMany(text => text.Split(' ').Select(word => new Word(word))).ToList();
    }

    // Method to hide a random word in the scripture
    public void HideRandomWord()
    {
        var random = new Random();
        int index;

        // Continue hiding words until all are hidden
        do
        {
            index = random.Next(Words.Count);
        } while (Words[index].IsHidden);

        Words[index].IsHidden = true;
    }

    // Method to display the scripture with hidden words
    public void Display()
    {
        Console.WriteLine(Reference.ToString());
        foreach (var word in Words)
        {
            Console.Write(word.IsHidden ? "___ " : $"{word.Text} ");
        }
        Console.WriteLine();
    }
}
