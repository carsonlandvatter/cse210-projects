using System;

class Program
{
    static void Main(string[] args)
    {
        Job firstJob = new Job();
        //first instance

        firstJob._company = "Verizon Wireless";
        firstJob._jobTitle = "Technology Consultant";
        firstJob._startYear = 2024;
        firstJob._endYear = 2025;

        Job secondJob = new Job();
        //second instance

        secondJob._company = "Apple";
        secondJob._jobTitle = "Technical Specialist";
        secondJob._startYear = 2026;
        secondJob._endYear = 2028;

        Resume jobResume = new Resume();
        //resume instance

        jobResume._jobs.Add(firstJob);
        jobResume._jobs.Add(secondJob);
        //appending the instance of the first job and second job to the _jobs list.

        jobResume.DisplayResume();
        //Calling the display method.
    }
}