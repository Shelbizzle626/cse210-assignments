using System.Linq;
public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
       
    }

    public string GetDisplayText()
    {
        string wordDisplay = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordDisplay}";
    }
    
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}