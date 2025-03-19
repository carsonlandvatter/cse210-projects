using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        // This is creating an instance for job1

        job1._company = "Verizon";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        //This creates an instance for job2

        job2._company = "EOS Fitness";
        job2._jobTitle = "Fitness Counselor";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myresume = new Resume();
        //This creates an instance for myresume

        myresume._name = "Carson Landvatter";
        myresume._jobs.Add(job1);
        //This appends the job to the list
        myresume._jobs.Add(job2);

        myresume.DisplayResumeDetails();
        //This displays the resume information
        
    }
}