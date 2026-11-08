class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _responses = new List<string> {};
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private void DisplayPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        Console.WriteLine($"---{prompt}---");
    }

    public void ListingCycle()
    {
        DisplayStartMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        _timer.DisplayReverseCountdown(4);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _responses.Add(input);

            TimeSpan elapsed = DateTime.Now - startTime;
            if (elapsed.TotalSeconds > _duration)
            {
                break;
            }
        }
        Console.WriteLine($"You came up with {_responses.Count()} answers!");
        DisplayEndMessage();
    }
}