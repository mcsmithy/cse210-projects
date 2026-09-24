using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter Number: ");
            string input_string = Console.ReadLine();
            input = int.Parse(input_string);
            if (input != 0)
            {
                numbers.Add(input);                
            }
        }
        while(input != 0);

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        decimal average = (decimal)total / numbers.Count;

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        int smallest = 1000000000;
        foreach (int number in numbers)
        {
            if (number < smallest && number >= 0)
            {
                smallest = number;
            }
        }
        
        Console.WriteLine($"Sum: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Smallest Nonnegative: {smallest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}