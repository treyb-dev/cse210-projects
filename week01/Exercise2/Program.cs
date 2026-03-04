using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you grade percentage: ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letter = "";
        string sign = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = numberGrade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }
        else if (letter == "F")
        {
            sign = "";
        }
    
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulation you passed!!!");
        }
        else
        {
            Console.WriteLine("Keep putting in your best.");
        }
    }
}