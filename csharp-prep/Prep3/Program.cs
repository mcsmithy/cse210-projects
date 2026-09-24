using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        //setup
        //Console.Write("What is the magic number? ");
        //string input = Console.ReadLine();
        //int number = int.Parse(input);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;
        int score = 0;

        //game
        Console.WriteLine("Welcome to the number guessing game!");
        while (guess != number)
        {
                
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            score = score + 1;
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"Congrats! You guessed the number {number}!");
            }
        }
        Console.WriteLine($"It took you {score} guesses!");
    }
}