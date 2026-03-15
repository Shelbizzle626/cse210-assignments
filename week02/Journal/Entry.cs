using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
    }
    public void Display()
{
        Console.WriteLine($"[{_date}] {_promptText} - {_entryText}");
}
}