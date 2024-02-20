public class Running : Activity
{
    private float _distance;
    private float _speed;
    private float _pace;


    public Running(float distance, float lenght) : base (lenght)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        Console.Write($" ({_lenght} min) - ");
        Console.Write($"Distance {_distance} km, ");
        Console.Write($"Speed {Speed().ToString("0.00")} kph, ");
        Console.Write($"Pace {Pace().ToString("0.00")} min per km");
    }

    public override float Speed()
    {
        _speed = (_distance / _lenght) * 60;
        return _speed;
    }
    public override float Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }

}