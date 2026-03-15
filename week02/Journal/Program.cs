using System;

//I added infomration in the Journal.cs file so the file is saved in an excel sheet.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        string choice;
        do
        {
        Console.WriteLine("1. Add Entry ");
        Console.WriteLine("2. Display All ");
        Console.WriteLine("3. Save to File ");
        Console.WriteLine("4. Load from File ");
        Console.WriteLine("5. Quit ");

        Console.Write("What would you like to do? ");
        choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("Your response: ");
                string userResponse = Console.ReadLine();

                Entry anEntry = new Entry(prompt, userResponse); 
                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }

        } while (choice != "5");

    }
}