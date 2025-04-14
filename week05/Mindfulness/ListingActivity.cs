using System.Data.SqlTypes;
using System.IO.Pipes;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);

        Console.WriteLine("Start listing now!");
        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"--- {prompt} ---");
        
    }


    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}