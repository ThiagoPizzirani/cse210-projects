public abstract class Activity
{

    private string _date;
    protected float _lenght;
    private float _distance;
    private float _speed;
    private float _pace;


    public Activity(float lenght)
    {
        _lenght = lenght;
    }

    public abstract void GetSummary();

    public virtual float Distance()
    {
        return _distance;
    }
    public virtual float Speed()
    {
        return _speed;
    }
    public virtual float Pace()
    {
        return _pace;
    }

}