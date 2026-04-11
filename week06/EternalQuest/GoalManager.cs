
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nLevel {GetLevel()} | You have {_score} points. ");
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoals:");
        ListGoalNames();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal would you like to create? ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal ");
        Console.WriteLine("4. Negative Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target (how many times): ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else if (type == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoalNames();
        Console.Write("Choice: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();
        
        if (goal is NegativeGoal)
        {
            _score -= Math.Abs(goal.GetPoints());
            Console.WriteLine($"You lost {goal.GetPoints()} points.");
        }
        else
        {
            _score += goal.GetPoints();
            Console.WriteLine($"You earned {goal.GetPoints()} points!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) g.RecordEvent();
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));
                int timesCompleted = int.Parse(data[3]);
                for (int j = 0; j < timesCompleted; j++) g.RecordEvent();
                _goals.Add(g);
            }
            else if (type == "NegativeGoal")
            {
                _goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));
            }
        }
        Console.WriteLine("Goals loaded!");
    }


}