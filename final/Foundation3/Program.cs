using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture lecture = new Lecture("Dr. Brown Fisher", 200,"The Higher Education Gap", "Come and learn what it takes to improve the competitiveness of US education", "April 20, 2024", "1:00 PM", "2381 Farcicle Road, Austin, TX");
        Reception reception = new Reception("RSVP-Health@Hhealthevent.com", "Nutrition and Health in Hospitals", "Learn the best practices from experts in the field", "July 17, 2024", "9:00 AM", "1000 Main Avenue, San Jose, CA");
        Outdoor outdoor = new Outdoor("Partially Cloudy 48F", "Explore Birds from Idaho", "Bring your binoculars and we provide the rest for an amazing day", "August 07, 2024", "8:30 AM", "4555 Principal Street, Boise, ID");
    
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);


        foreach (Event type in events)
        {
            Console.Write($"  ------STANDARD Marketing------");
            type.Standard();
            Console.WriteLine("__________________________________________");

            Console.Write($"Event Type: {type.GetType()}");
            Console.Write($"  ------FULL DETAILS Marketing------");
            type.Standard();

            string compare = Convert.ToString(type.GetType());
            if (compare == "Lecture")
            {
                lecture.FullDetail();
            }
            else if (compare == "Reception")
            {
                reception.FullDetail();
            }
            else if (compare == "Outdoor")
            {
                outdoor.FullDetail();
            }

            Console.WriteLine("__________________________________________");

            Console.Write($"Event Type: {type.GetType()}");
            Console.Write($"  ------SHORT Marketing------");
            type.Short();
            Console.WriteLine("__________________________________________");
        }
    
    
    }
}