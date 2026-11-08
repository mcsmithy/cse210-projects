class Activity
{
    protected string _activityName = "";
    protected string _activityDescription = "";
    public int _duration = 0;
    protected Timer _timer = new Timer();

    public Activity()
    {
        
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_activityName} activity! \n{_activityDescription} \nEnter the duration of the activity (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        _timer.DisplayAnimation(6);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("Congrats!");
        _timer.DisplayAnimation(6);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        _timer.DisplayAnimation(6);
        Console.Clear();
    }
}