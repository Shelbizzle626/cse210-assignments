using System;
//I added a NegativeGoal class to deduct points if I do something I don't want to.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}