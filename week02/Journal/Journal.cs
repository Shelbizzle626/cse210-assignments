using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string date = entry._date.Replace("\"", "\"\"");
                string prompt = entry._promptText.Replace("\"", "\"\"");
                string text = entry._entryText.Replace("\"", "\"\"");
                
                writer.WriteLine($"\"{date}\",\"{prompt}\",\"{text}\"");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line = reader.ReadLine();
            while (line != null) 
            {
                string[] parts = line.Split(',');
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"');
                string text = parts[2].Trim('"');

            Entry newEntry = new Entry(prompt, text);
            newEntry._date = date;
            _entries.Add(newEntry);

            line = reader.ReadLine();
            }
        }
    }
    
}