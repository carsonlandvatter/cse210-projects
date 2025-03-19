public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        //Job is the data type, job is a temporary variable name, and _jobs is the variable name of the list that will be iterated through.
        {
            job.DisplayJobDetails();
        }
    }
}