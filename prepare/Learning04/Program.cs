class Program
{
    static void Main()
    {
        Assignment first = new Assignment("Jorge", "Spanish");
        Console.WriteLine(first.GetSummary());

        MathAssignment second = new MathAssignment("3.4", "1-9", "Jimmy", "Fractions");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList());

        WritingAssignment third = new WritingAssignment("Hawkeye Hears a Who", "Dr Strange", "Introductory Writing");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation());
    }
}