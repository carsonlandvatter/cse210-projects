//Exceeded Requirements by saving another item to the journal entries. I included "mood" within each entry.
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string choices = Console.ReadLine();

        if (choices == "1")
        {
            PromptGenerator promptGen /*This stores the variable object reference that stores the instance of PromptGenerator so that we can use it later*/ = new PromptGenerator();
            //This creates an instance for PromptGenerator.
            string prompt = promptGen.GetRandomPrompt();
            //This creates a variable. 

            Console.WriteLine(prompt);
            string response = Console.ReadLine();

            Console.Write("How would you describe your mood today? ");
            string mood = Console.ReadLine();

            Entry entry = new Entry(prompt, response, mood);
            journal.AddEntry(entry);
        }
        else if (choices == "2")
        {
            journal.DisplayAll();
        }
        else if (choices == "3")
        {
            Console.Write("What is the filename? ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
        }
        else if (choices == "4")
        {
            Console.Write("Enter filename to save to: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }
        else if (choices == "5")
        {
            break;
        }
        else 
        {
            Console.WriteLine("Invalid choice.");
        }
        }
    }
}