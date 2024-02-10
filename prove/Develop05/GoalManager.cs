using System.ComponentModel;
using System.IO; 

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public int Score(int points)
    {
       _score = _score + points;
       DisplayPlayerInfo(_score);
        return _score;
    }

    public void Start()
    {
        int choice = 0;

        Console.WriteLine($"\n-- Welcome to the Personal Goals App --");

        Console.WriteLine($"Your score is {_score} points");

        while (choice != 6)
        {
            Console.WriteLine($"\nMenu Options: ");
            Console.WriteLine($"  1 - Create New Goal");
            Console.WriteLine($"  2 - List Goals");
            Console.WriteLine($"  3 - Save Goals");
            Console.WriteLine($"  4 - Load File with Goals");
            Console.WriteLine($"  5 - Record an Event");
            Console.WriteLine($"  6 - End the program");
            Console.Write($"\nChoose the number of an action: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) //Create New Goal
            { 
                CreateGoal();
            }

            if (choice == 2) // List Goals
            { 
                ListGoalNames(); 
            }

            if (choice == 3) // Save Goals
            { 
                SaveGoals(); 
            }

            if (choice == 4) // Load File with Goals
            { 
                LoadGoals(); 
            }

            if (choice == 5) // Record an Event
            { 
                RecordEvent(); 
            }

        }

    }
    
    public void DisplayPlayerInfo(int score)
    {
        Console.WriteLine($"\nYou have {score} points");

        if (score > 100 && score < 250)
        {
            Console.Write("Keep it up! You achieved the BRONZE Level");
            ShowSpinner();
        }
        else if (score > 250 && score < 500)
        {
            Console.Write("Wow! You achieved the SILVER Level");
            ShowSpinner();
        }
        else if (score >= 500)
        {
            Console.Write("Outstanding! You achieved the GOLD Level");
            ShowSpinner();
        }
    }

    public void ListGoalNames()
    {
        foreach (Goal goalDetail in _goals)
        {
            Console.WriteLine(goalDetail.GetDetailsString());
        }
    }

    public void CreateGoal()
    {   
        int goalChoice = 0;
        Console.WriteLine("\nCreate a Goal");

        Console.WriteLine($"\nThe types of Goal are: ");
        Console.WriteLine($"  1 - Simple Goal");
        Console.WriteLine($"  2 - Eternal Goal");
        Console.WriteLine($"  3 - Checklist Goal");
        Console.Write($"\nChoose the number of a type of goal: ");
        goalChoice = int.Parse(Console.ReadLine());

        Console.Write($"What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write($"What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write($"What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalChoice == 1) //Simple Goal
        { 
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }

        if (goalChoice == 2) // Eternal Goal
        { 
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }

        if (goalChoice == 3) // Checlist Goal
        {  
            Console.Write($"How many times this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write($"What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }

    }

    public void SaveGoals()
    {
        Console.WriteLine("\nWhat is the filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goalDetail in _goals)
            {
            outputFile.WriteLine(goalDetail.GetStringRepresentation());
            }             
         }

        Console.WriteLine ("File Saved");
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("\nWhat is the filename of the goal file? ");
        string file = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
           string[] parts = line.Split("|");

            string className = parts[0];

            if (className == "")
            {
                _score = int.Parse(parts[0]);

            }

            if (className == "SimpleGoal")
            {
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]); 
            
            SimpleGoal simple = new SimpleGoal(shortName, description, points);
            _goals.Add(simple);
            }

            if (className == "EternalGoal")
            {
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]); 
            
            EternalGoal eternal = new EternalGoal(shortName, description, points);
            _goals.Add(eternal);
            }

            if (className == "ChecklistGoal")
            {
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]); 
            int bonus = int.Parse(parts[4]);
            int target = int.Parse(parts[5]); 
            
            ChecklistGoal checklist = new ChecklistGoal(shortName, description, points, target, bonus);
            _goals.Add(checklist);
            }
            
        }

    }  
    
    public void RecordEvent()
    {
        Console.WriteLine("\nRecord an Event");

        int count = 1;

       foreach (Goal goalDetail in _goals)
        {
            Console.WriteLine($"{count} - {goalDetail.GetName()}");
            count++;
        }
        Console.Write("Which goal do you want to record - use the number: ");
        int option = int.Parse(Console.ReadLine());

        _goals[option-1].RecordEvent();

       
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

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


}