using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();

        Running run = new Running(10, 35);
        Cycling bike = new Cycling(21, 90);
        Swimming swim = new Swimming(20, 55);

        Running run2 = new Running(21, 65);
        Cycling bike2 = new Cycling(50, 120);
        Swimming swim2 = new Swimming(35, 80);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);
        activities.Add(run2);
        activities.Add(bike2);
        activities.Add(swim2);

        Console.WriteLine("\nSummary of the Exercises - The Local Fitness Center");
        Console.WriteLine("_________________________________________________________\n");

        foreach (Activity exercise in activities)
        {
            
            DateTime _date = DateTime.Now;
            Console.Write($"{_date.ToString("dd MMM yyyy")} ");
            Console.Write($"{exercise.GetType()}");
            exercise.GetSummary();
            Console.WriteLine("\n");
        }
        Console.WriteLine("_________________________________________________________");
    }
}