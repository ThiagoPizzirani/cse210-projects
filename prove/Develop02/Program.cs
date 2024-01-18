using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        static void MenuSelection()
        {
        int menuChoice = 0;
        
        Journal myjournal = new Journal();

        while (menuChoice !=5) 
            {
            Console.WriteLine(" ");   
            Console.WriteLine("Please select one of the choices by using the number: ");
            Console.WriteLine("1 - Write an entry in your journal");
            Console.WriteLine("2 - Display your journal");
            Console.WriteLine("3 - Load a journal");
            Console.WriteLine("4 - Save your journal");
            Console.WriteLine("5 - Exit the program");
            Console.Write("What would you like to do? ");
            menuChoice = int.Parse(Console.ReadLine());  

            

            if (menuChoice == 1)
                 {
                    PromptGenerator prompt = new PromptGenerator();
                    
                    DateTime dateText = DateTime.Now;
                    string date = dateText.ToShortDateString();

                    Entry anEntry = new Entry();
                    anEntry._promptText = prompt.GetRandomPrompt();
                    anEntry._date = date;
                    anEntry._entryText = anEntry.Display();

                    myjournal.AddEntry(anEntry);

                 }
            else if (menuChoice == 2)
                 {
                   // Console.WriteLine("Option 2 - Display your journal");
                    myjournal.DisplayAll();

                 }
            else if (menuChoice == 3)
                 {
                   // Console.WriteLine("Option 3 - Load a journal");

                    Console.Write("What is the name of the file to be loaded? (add .txt) ");
                    string file = Console.ReadLine();
                    
                    myjournal.LoadFromFile(file);

                 }
            else if (menuChoice == 4)
                {
                    //Console.WriteLine("Option 4 - Save your journal");

                    Console.Write("What is the name of the file to be saved? (add .txt) ");
                    string file = Console.ReadLine();

                    myjournal.SaveToFile(file);

                }

            }
        }   

        MenuSelection(); 

    }

}
