using System;

class Program
{
    static void Main(string[] args)
    {
  
        static void MenuSelection()
        {
            string choice = "";
            string StringSorter = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.";
        
            Reference reference = new Reference("2 Nephi", 25, 26);
            Scripture myscripture = new Scripture(StringSorter, reference);
            Word text = new Word(StringSorter);

            Console.WriteLine($"{reference.GetDisplayText()} - {text.GetDisplayText()}");

            while (choice != "quit") 
            {
                
                Console.WriteLine("\nWrite \'quit\' to finish the program or press Enter to continue. ");
                choice = Console.ReadLine();  
                
                Console.Clear();
                Console.WriteLine($"{reference.GetDisplayText()} - {myscripture.HideRandomWords(StringSorter)}");
            }    
        
        }
        
        MenuSelection();
    }
   
}