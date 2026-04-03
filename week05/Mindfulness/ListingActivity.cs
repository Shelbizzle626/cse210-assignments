
using System.ComponentModel;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {
        _prompts = new List<string>();
    }

    public void Run() {}
    public void GetRandomPrommpt() {}
    public List<string> GetListFromUser()
{
    return new List<string>();
}
}