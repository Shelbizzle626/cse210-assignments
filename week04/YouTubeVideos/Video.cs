

using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayAll()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}