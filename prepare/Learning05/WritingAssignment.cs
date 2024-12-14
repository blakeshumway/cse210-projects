public class WritingAssignment : Assignment
{
    //this variable is specific to the WritingAssignment class
    private string _title;

    //we set Writing Assignment specific constructors                         we set Assignemnt constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}