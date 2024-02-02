public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;  
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Actvity.");
        Console.WriteLine($"\n{_description}");

        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

     public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\nActivity completed - {_duration} seconds of the {_name} Activity");
        
        Console.Write("\nWell Done! ");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            string bar = spinner[count];
            Console.Write(bar);
            Thread.Sleep(500);
            Console.Write("\b \b");
            count++;

            if (count >= spinner.Count)
            {
                count = 0;
            }
        }

    }

    public void ShowCountDown (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}