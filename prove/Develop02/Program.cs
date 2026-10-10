// This is my program. It meets all of the requirements, and I went above and beyond in two ways.
// The first way is I added a size method to the journal that returns how many entries are in the current journal, and shows that number to the user under display in the menu.
// The second way is I added additional information to each entry. When creating a new entry, the user will also input a rating of their day.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.Write($"\nPlease select one of the following choices:\n1. Write\n2. Display ({journal.Size()} entries)\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                journal.Write();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Your entries:");
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("You ain't that good at follown' instructions!");
            }
        }
    }
}