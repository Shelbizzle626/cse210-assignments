
public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
     //points will be subtracted in GoalManager   
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[-] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal: {_shortName}, {_description}, {_points}";
    }
}