class Timer
{
    private List<string> _animations = new List<string> {"|", "/", "-", "\\"};

    public Timer()
    {

    }

    public void DisplayAnimation(int timerDuration)
    {
        for (int i = 0; i <= timerDuration * 4; i++)
        {
            Console.Write(_animations[i % _animations.Count()]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void DisplayCountdown(int timerDuration)
    {
        for (int i = 0; i <= timerDuration; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayReverseCountdown(int timerDuration)
    {
        for (int i = timerDuration; i >= 0; i--)
        {
            Console.Write(i+1);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}