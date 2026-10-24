//I exceded requirements by storing multiple scriptures in a list and randomly choosing one.
class Program
{
    static void Main()
    {
        List<Scripture> scriptures = [];
        scriptures.Add(new Scripture(new Reference("Mosiah", 2, 41), "41 And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."));
        scriptures.Add(new Scripture(new Reference("Ether", 15, 31, 32), "30 And it came to pass that when Coriantumr had leaned upon his sword, that he rested a little, he smote off the head of Shiz. 31 And it came to pass that after he had smitten off the head of Shiz, that Shiz raised up on his hands and fell; and after that he had struggled for breath, he died."));
        scriptures.Add(new Scripture(new Reference("John", 11, 35), "35 Jesus wept."));

        int randomIndex = Random.Shared.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress enter to continue or type \"quit\" to finish:");
        string input = Console.ReadLine();
        while (input != "quit")
        {
            Console.Clear();
            int wordsRemaining = scripture.HideWords();
            scripture.Display();
            if (wordsRemaining == 0)
            {
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to finish:");
            input = Console.ReadLine();
        }
    }
}