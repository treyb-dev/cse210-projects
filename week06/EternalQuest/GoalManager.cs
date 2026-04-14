using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (choice == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else if (choice == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine());

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i}. {_goals[i].GetStatus()} {_goals[i].GetName()}");

            if (_goals[i] is ChecklistGoal cg)
                Console.Write($" ({cg.GetProgress()})");

            Console.WriteLine();
        }
    }

    public void Save()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void Load()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[6])
                );
                _goals.Add(goal);
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }
}