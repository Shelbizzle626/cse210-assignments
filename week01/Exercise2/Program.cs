using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade average? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;

        if (grade >= 90)
    {
        letter = "A";
    }
        else if (grade >= 80)
    {
        letter = "B";
    }
        else if (grade >= 70)
    {
        letter = "C";
    }
        else if (grade >= 60)
    {
        letter = "D";
    }
        else
    {
        letter = "F";
    }
    int lastDigit = grade % 10;
    string sign;

    if (lastDigit >= 7)
        {
            sign = "+";
        }
    else if (lastDigit < 3)
        {
            sign = "-";
        }
    else
        {
            sign = "";
        }
    if (letter == "A" && sign == "+")
        {
            sign = "";
        }
    if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the class with a {letter}{sign}!");
        }
        else
        {
            Console.WriteLine($"You got a {letter}{sign}. Stay focused and you'll get it next time.");
        }
    }
    
}