public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {

        Console.WriteLine($"\nPrompt: {_promptText}");
        Console.Write("> ");
        Console.Write("");
        string _entryText = Console.ReadLine();

        return _entryText;
    }


}