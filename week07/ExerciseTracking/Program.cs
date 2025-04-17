using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2020, 1, 5), 45, 20.0);
        activities.Add(cyclingActivity);

        RunningActivity runningActivity = new RunningActivity(new DateTime(2019, 11, 9), 30, 3.0);
        activities.Add(runningActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2021, 8, 10), 40, 20);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}