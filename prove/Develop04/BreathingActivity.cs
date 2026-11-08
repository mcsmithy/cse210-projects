class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void BreathCycle()
    {
        DisplayStartMessage();
        Timer timer = new Timer();
        for (int i = 0; i <= _duration; i += 8)
        {
            Console.WriteLine("Breath in");
            _timer.DisplayReverseCountdown(3);
            Console.WriteLine("Breath out");
            _timer.DisplayReverseCountdown(3);
        }
        DisplayEndMessage();
    }
}