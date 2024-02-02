using System.Runtime.InteropServices;

public class ReflectingActivity : Activity
{

private List<string> _prompts;
private List<string> _questions;

public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Reflecting - Get Ready...");
        ShowSpinner(4);

        Core();

        DisplayEndingMessage();
    }


    private void Core()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         Console.WriteLine("\n");
            DisplayPrompt();
            ShowCountDown(8);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(8);
        }
    }

     public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string random = _prompts[randIndex];
        
        return random;
    }

    public string GetRandomQuestions()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    
        Random rnd = new Random();
        int randIndex = rnd.Next(_questions.Count);
        string random = _questions[randIndex];
        
        return random;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("");
        Console.WriteLine(GetRandomQuestions());
    }

}