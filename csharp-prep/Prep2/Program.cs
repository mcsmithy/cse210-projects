using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int numberGrade = int.Parse(input);
        string letterGrade;
        string sign = "";
        
        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (!(letterGrade == "A" || letterGrade == "F"))
        {
            if (numberGrade % 10 >= 7)
            {
                sign = "+";
            }
            else if (numberGrade % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letterGrade}{sign}");
        if (numberGrade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Rats. Better luck next time.");
        }
    }
}