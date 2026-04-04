using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nWelcom to the Mindfulness Program\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start a breathing activity ");
            Console.WriteLine(" 2. Start a reflection activity ");
            Console.WriteLine(" 3. Start a listing activity ");
            Console.WriteLine(" 4. Quit ");
            Console.WriteLine("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("\nGoodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again. ");
                    continue;
            }

            activity.Run();

        }
    }
}