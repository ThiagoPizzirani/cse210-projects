public class Reception : Event
{
    private string _email;

    public Reception(string email, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _email = email;
    }

     public void FullDetail()
    {
        Console.WriteLine($"RSVP email: {_email}");
    }
}