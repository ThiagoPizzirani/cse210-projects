using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       static void MenuSelection()
        {   
            List<string> activities = new List<string>();
            int choice = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to the Relax App");
                Console.WriteLine($"\nMenu Options: ");
                Console.WriteLine($"  1 - Start Breathing activity");
                Console.WriteLine($"  2 - Start Reflecting activity");
                Console.WriteLine($"  3 - Start Listing activity");
                Console.WriteLine($"  4 - How many activities done");
                Console.WriteLine($"  5 - Quit program");
                Console.Write($"\nChoose the number of an Activity: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1) //Breating Activity
                {
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.Run();
                    activities.Add("Breathing");
                }

                if (choice == 2) // Reflecting Activity
                {
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.Run();
                    activities.Add("Reflecting");
                }

                if (choice == 3) // Listing Activity
                {
                    ListingActivity listing = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having your list as many things as you can in a certain area.");
                    listing.Run();
                    activities.Add("Listing");
                }
                if (choice == 4) // Total Activity
                {
                    foreach (string activity in activities)
                    {
                        if (activity == "Breathing")
                        {count1++;}
                        if (activity == "Reflecting")
                        {count2++;}
                        if (activity == "Listing")
                        {count3++;}
                    }

                    Console.WriteLine("\nActivities Completed");
                    Console.WriteLine($"Breathing - {count1}");
                    Console.WriteLine($"Reflecting - {count2}");
                    Console.WriteLine($"Listing - {count3}");
                }

            }
        
        }

        MenuSelection();
    }

}