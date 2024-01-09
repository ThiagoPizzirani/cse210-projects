using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your Last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}