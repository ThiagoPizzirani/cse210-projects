public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations you earned {_points} points");
        GoalManager goal = new GoalManager();
        goal.Score(_points);
    }

    public override string GetDetailsString()
    {
        string goalDetail = $"[] {_shortName} - {_description} - You have completed {_amountComplete}/{_target}";
        return goalDetail;
    }

    
    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        string className = GetType().Name;
        return $"{className}|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountComplete}";
    }

}