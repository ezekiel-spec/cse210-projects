using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times when you have shown strength and resilience.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you're ready, press Enter.");
        Console.ReadLine();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}
