public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("Now ponder each of the following questions...");
        ShowSpinner(3);

        int elapsedTime = 0;
        int questionDuration = 5;

        while (elapsedTime < GetDuration())
        {
            DisplayQuestion();
            ShowSpinner(questionDuration);
            elapsedTime += questionDuration;
        }
    }

    public List<string> GetRandomPrompt()
    {
        return _prompts;
    }

    public List<string> GetRandomQuestion()
    {
        return _questions;
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Random rand = new Random();
        string question = _questions[rand.Next(_questions.Count)];
        Console.WriteLine($"> {question}");
    }
}