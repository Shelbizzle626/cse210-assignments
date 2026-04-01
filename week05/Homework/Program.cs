using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Shelby", "Fractions", "4.3", "2-12");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Shelby", "Persuasive Essays", "The Importance of Sleep");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}