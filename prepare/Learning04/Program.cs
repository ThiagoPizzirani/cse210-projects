using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("James", "New Homework");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Roberto Rodrigues","Fractions","7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("The Cause of WW2", "Mary Waters", "European History");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWrittingInformation());
    }
}