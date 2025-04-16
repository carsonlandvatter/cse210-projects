using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        int menuChoice = 0;

        while (menuChoice != 6)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.Write("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                CreateGoal();
            }
            else if (menuChoice == 2)
            {
                ListGoalNames();
            }
            else if (menuChoice == 3)
            {
                SaveGoals();
            }
            else if (menuChoice == 4)
            {
                LoadGoals();
            }
            else if (menuChoice == 5)
            {
                RecordEvent();
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine("Thank you for making and entering your goals. Hope you accomplish all of them.");
                return;
            }
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        int index = 1;
        foreach (Goal goal in _goals)
        {
            string checkbox = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{index}. {checkbox} {goal.GetDetails()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        //This creates a variable called newGoal that is able to hold any object of Goal or its subclasses.
        Goal newGoal = null;

        if (goalType == 1)
        {
            //This will take the users input and run the cunstuctor in SimpleGoal.
            newGoal = new SimpleGoal(shortName, description, points);
        }
        else if (goalType == 2)
        {
            newGoal = new EternalGoal(shortName, description, points);
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        }
        else 
        {
            Console.WriteLine("Sorry, that was not a menu option.");
            return;
        }

        //Adds the newGoal variable to the list
        _goals.Add(newGoal);

    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.WriteLine("Which goal did you accomplish?");
        int goalAccomplished = int.Parse(Console.ReadLine());

        if (goalAccomplished >= 1 && goalAccomplished <= _goals.Count)
        {
            Goal goalChosen = _goals[goalAccomplished - 1];
            int pointsAchieved = goalChosen.RecordEvent();

            _score += pointsAchieved;
            Console.WriteLine($"Congradulations! You have earned {pointsAchieved} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Your choice was invalid.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string goalType = parts[0];

                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    goal.SetAmountCompleted(amountCompleted);
                    _goals.Add(goal);
                }
            }
        }
        else
        {
            Console.WriteLine("No file found.");
        }


    }
}