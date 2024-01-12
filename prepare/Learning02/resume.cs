using System;

public class Resume
{
    public string _name;
    public List<Jobs> _jobs = new List<Jobs>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Jobs j in _jobs)
        {
            j.Display();
        }       

    }

}