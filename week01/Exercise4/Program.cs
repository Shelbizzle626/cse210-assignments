using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine(" Enter a list of numbers. Type 0 when you're finished. ");
        
        int input;
        do
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int total = numbers.Sum();
        Console.WriteLine($"The sum is {total}");

        double average = numbers.Average();
        Console.WriteLine($"The average is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");
    }
}