using System;
using System.Collections.Generic;
using System.IO;

//My stretch goal was loading scriptures at random from a txt file.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        List<Scriptures> scriptures = new List<Scriptures>();
        
        foreach (string line in File.ReadLines("scripture.txt"))
        {
            if (string.IsNullOrWhiteSpace(line))
            continue;
            string[] parts = line.Split('|');

            string book = parts[0];
            int chapter = int.Parse(parts[1]);

            Reference reference;
            string text = "";

            if (parts.Length == 4)
            {
                reference = new Reference(book, chapter, int.Parse(parts[2]));
                text = parts[3].Trim();
            }
            else
            {
                reference = new Reference(book, chapter, int.Parse(parts[2]), int.Parse(parts[3]));
                text = parts[4].Trim();
            }
            Console.WriteLine($"Text being loaded: '{text}'");
            scriptures.Add(new Scriptures(reference, text));
        }

        Random random = new Random();
        Scriptures scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}