public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        //needed to make a student name method so that it could be accessed here.
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}