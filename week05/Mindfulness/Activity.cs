public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Write($"\nWelcome to the Breathing Activity.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        //Creates a list that has the character that would be used for the spinner
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int totalTime = seconds * 1000; //Holds the total time in milliseconds.
        int interval = 250; //Sets the value for 0.25 seconds per frame.

        for (int elapsed = 0; elapsed < totalTime; elapsed += interval)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(interval);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}