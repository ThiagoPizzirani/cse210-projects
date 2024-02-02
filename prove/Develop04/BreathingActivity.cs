public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Breathing - Get Ready...");
        ShowSpinner(4);

        Core();

        DisplayEndingMessage();
    }

    private void Core()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write($"Breathe in.... ");
            ShowCountDown(3);
            Console.Write($"\nand breathe out.... ");
            ShowCountDown(6);
            
        }
    }
}