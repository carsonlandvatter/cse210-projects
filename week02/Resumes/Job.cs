public class Job /*Job is a datatype*/ 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
    }
}