public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you earned {_points} points");
        GoalManager goal = new GoalManager();
        goal.Score(_points);
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        string className = GetType().Name;
        return $"{className}|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

}