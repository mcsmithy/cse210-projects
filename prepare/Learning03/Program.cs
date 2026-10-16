using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            Fraction fraction = new Fraction();
            int top = Random.Shared.Next(100);
            int bottom = Random.Shared.Next(100);
            fraction.SetTop(top);
            fraction.SetBottom(bottom);
            Console.WriteLine($"Fraction {i}: | String: {fraction.GetFractionString()} | Number: {fraction.GetDecimalValue()}");
        }
    }
}