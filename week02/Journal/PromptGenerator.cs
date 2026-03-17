using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        _prompts.Add("What do you feel most accomplished about today? ");
        _prompts.Add("Did anything make you feel sad today? ");
        _prompts.Add("Who did you get to visit with today? ");
        _prompts.Add("Did you feel the spirit today?");
        _prompts.Add("What did you ask Heavenly Father for help with today? ");
    }

    public string GetRandomPrompt()
{
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
}
}