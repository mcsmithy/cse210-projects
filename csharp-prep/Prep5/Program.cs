using System;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");           
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;            
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        string numberString = Console.ReadLine();
        year = int.Parse(numberString);            
    }

    static int SquareNumber(int x)
    {
        int square = x * x;
        return square;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromtUserBirthYear(out int year);
        DisplayResult(name, number, year);
    }
}