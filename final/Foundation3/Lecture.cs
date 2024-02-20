public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speaker, int capacity,string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

     public void FullDetail()
    {
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");

    }
}