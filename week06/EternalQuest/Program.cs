using System;

/*
EXCEEDING REQUIREMENTS:
1. Added leveling system (user levels up every 1000 points)
2. Added special status symbol for Eternal Goals ([∞])
*/

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.RecordEvent();
            else if (choice == "3") manager.DisplayGoals();
            else if (choice == "4") manager.DisplayScore();
            else if (choice == "5") manager.Save();
            else if (choice == "6") manager.Load();
            else if (choice == "7") break;
        }
    }
}