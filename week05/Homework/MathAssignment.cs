
public class MathAssignment : Assignment
{
    private string _Section;
    private string _problems;

    public MathAssignment(string studentName, string topic, string Section, string problems) : base (studentName, topic)
    {
        _Section = Section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_Section} Problems {_problems}";
    }
}