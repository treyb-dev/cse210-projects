using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // - Added a library of scriptures
        // - Randomly selects a scripture at runtime

        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"));

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"));

        library.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd I shall not want"));

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        string input = "";

        while (input.ToLower() != "quit" && !scripture.AllHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            input = Console.ReadLine();
            
            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}