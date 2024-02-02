public class ListingActivity : Activity
{

    private int _count = 0;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Listing - Get Ready...");
        ShowSpinner(4);

        GetRandomPrompt();
        GetListFromUser();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string random = _prompts[randIndex];
        
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($"{random}");

    }

    public List<string> GetListFromUser()
    {
            Console.WriteLine("\nYou may begin in: ");
            ShowCountDown(5);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            List<string> answers = new List<string>();

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                answers.Add(Console.ReadLine());

            }
            Console.WriteLine($"\nYou have listed {answers.Count} items");
            return answers;
    }


}