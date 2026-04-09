using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard.",
        "Think of a time you stood up for someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
        : base("Reflection", "Reflect on times you showed strength.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}