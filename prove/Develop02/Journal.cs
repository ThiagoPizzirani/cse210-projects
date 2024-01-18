using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry anEntry)
    {
       _entries.Add(anEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Inside DisplayAll");

       foreach (Entry content in _entries)
        {
            Console.WriteLine("Inside For Each");
            Console.Write("Entered the forEach in the DisplayALl - \n");
            Console.WriteLine($"{content._date} {content._promptText}");
            Console.WriteLine($"{content._entryText} \n");
       }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Inside SaveToFile");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
             foreach (Entry content in _entries)
             {
             outputFile.WriteLine($"{content._date}|{content._promptText}|{content._entryText}");
             }             
         }

        Console.WriteLine ("File Saved");
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Inside LoadFromFile");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
           string[] parts = line.Split("|");

            Entry content = new Entry();
            content._date = parts[0];
            content._promptText = parts[1];
            content._entryText = parts[2];

            Console.WriteLine($"{content._date}|{content._promptText}|{content._entryText}"); // debug
            // Save the new entry to the journal
            _entries.Add(content);
        }

    }
}