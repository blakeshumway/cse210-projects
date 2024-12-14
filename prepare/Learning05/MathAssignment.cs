public class MathAssignment : Assignment
{
    //these are variables specific to the MathAssignment class
    private string _textbookSection;
    private string _problems;

    //these are the MathAssignment specific constructors                                            these are the Assignment specific constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}