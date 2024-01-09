using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "";
        bool pass = false;
        Console.Write("What is your grade percentage? ");
        string gradeText = Console.ReadLine();
        int grade = int.Parse(gradeText);

        if (grade >= 90)
        {
            gradeLetter = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
            pass = true;
        }
         else if (grade >= 60)
        {
            gradeLetter = "D";
        }
         else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade letter is {gradeLetter}.");

        if (pass == true)
        {
            Console.WriteLine("Congratulations on passing the class!.");
        }
        else
        {
            Console.WriteLine("You can try again next semester.");
        }
    }
}