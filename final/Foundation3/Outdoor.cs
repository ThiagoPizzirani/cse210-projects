public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

       public void FullDetail()
    {
        Console.WriteLine($"Weather Forecast: {_weather}");
    }
}