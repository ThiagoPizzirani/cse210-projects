public class Swimming : Activity
{
    private float _distance;
    private float _speed;
    private float _pace;
    private int _laps;


    public Swimming(int laps, float lenght) : base (lenght)
    {
        _laps = laps;
    }

    public override void GetSummary()
    {
        Console.Write($" ({_lenght} min) - ");
        Console.Write($"Distance {Distance()} km, ");
        Console.Write($"Speed {Speed().ToString("0.00")} kph, ");
        Console.Write($"Pace {Pace().ToString("0.00")} min per km");
    }

     public override float Distance()
    {
        _distance = (_laps * 50) / 1000;
        return _distance;
    }
    public override float Speed()
    {
        _speed = _distance / _lenght;
        return _speed;
    }
    public override float Pace()
    {
        _pace = _lenght / _distance;
        return _pace;
    }

}