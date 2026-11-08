// I exceeded the requirements for this activity by keeping track of how long the user spent on each activity and showing that number when they quit the program.
class Program
{
    static void Main()
    {
        int timeSpent = 0;
        Console.Clear();
        while (true)
        {
            Console.Write($"\nMenu Options:\n  1. Start Breathing Activity\n  2. Start Reflection Activity\n  3. Start Listing Activity\n  4. Quit\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.BreathCycle();
                timeSpent += activity._duration;
            }
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.ReflectionCycle();
                timeSpent += activity._duration;
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.ListingCycle();
                timeSpent += activity._duration;
            }
            else if (choice == 4)
            {
                Console.WriteLine($"You spent {timeSpent} seconds in the activities.");
                break;
            }
            else
            {
                Console.WriteLine("You ain't that good at follown' instructions!");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}