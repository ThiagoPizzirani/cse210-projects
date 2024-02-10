using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return $"{_shortName}";
    }

    public virtual string GetDetailsString()
    {
        string goalInfo = $"[] {_shortName} - {_description}";
        return goalInfo;
    }

    public abstract string GetStringRepresentation();

}