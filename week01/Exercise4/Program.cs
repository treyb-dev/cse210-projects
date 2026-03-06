using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter a list of numbers, type zero when finished.");
        int number = -1;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } 
        while (number != 0);

        int sumTotal = 0;
        int largestNumber = numbers[0];
        int smallestPositive = int.MaxValue;

        foreach (int i in numbers)
        {
            sumTotal += i;   

            if (i > largestNumber)
            {
                largestNumber = i;
            }
            if (i > 0 && i < smallestPositive)
            {
                smallestPositive = i;
            }
        }
        Console.WriteLine($"\nThe Sum is: {sumTotal}");

        float average = (float)sumTotal / numbers.Count;
        Console.WriteLine($"The Average is: {average}");
        
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}