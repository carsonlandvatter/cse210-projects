public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }

    public void DisplayResume()
    {
        foreach (Job job in _jobs)
        //iterates through each object in the list of jobs
        {
            job.Display();
            //displays each job to the console
        }
    }
}