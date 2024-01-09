using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int total = 0;
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 to stop");
        
        while (number != 0)
        {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

          if (number != 0)
          {
            numbers.Add(number);
          }
        }
        int largest = numbers[0];

        foreach (int num in numbers)
        {
            total += num;

            if (num > largest)
            {
                largest = num;
            }
        }

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The sum for the list is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}