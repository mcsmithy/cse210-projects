using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?"};
    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private void DisplayPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        Console.WriteLine($"---{prompt}---");
    }

    private void DisplayQuestion()
    {
        int randomIndex = Random.Shared.Next(_questions.Count);
        string question = _questions[randomIndex];

        Console.WriteLine(question);
    }

    public void ReflectionCycle()
    {
        DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        _timer.DisplayReverseCountdown(4);
        Console.Clear();
        for (int i = 0; i <= _duration; i += 8)
        {
            DisplayQuestion();
            _timer.DisplayAnimation(8);
        }
        DisplayEndMessage();
    }
}