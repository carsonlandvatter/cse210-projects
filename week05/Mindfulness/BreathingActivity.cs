public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {

        int elapsedTime = 0;
        int cycleTime = 6;

        while (elapsedTime < GetDuration())
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("Now breathe out...");
            ShowCountDown(6);

            elapsedTime += cycleTime;
        }
        
    }
}