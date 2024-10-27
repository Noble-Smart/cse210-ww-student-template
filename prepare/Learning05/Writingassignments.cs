public class WritingAssignment : Assignment
{
    private string _title;
    private int _pageNumber;

    public WritingAssignment(string studentName, string topic, string title, int pageNumber) 
        : base(studentName, topic)
    {
        _title = title;
        _pageNumber = pageNumber;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {base.StudentName}";
    }
}