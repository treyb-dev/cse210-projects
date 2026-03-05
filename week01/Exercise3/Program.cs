using System;

class Program
{
    static void Main(string[] args)
    {
        
        string playAgain = "yes";

        while(playAgain == "yes")
        {
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());

            int guessNumber = -1;
            int count = 0;
        

            while (guessNumber != magicNumber)
            {   
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                count += 1;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");  
                }
                
            }
            Console.WriteLine("You guessed it right!!!");
            Console.WriteLine($"It took you {count} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thank you");


    }
}