using System;
using System.ComponentModel.DataAnnotations;
//Exceeded requirements by adding a words left counter in the project.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture myScripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish, but have everlasting life.");
        
        while (true)
        {
            Console.Clear();
            myScripture.Display();
            Console.WriteLine($"\nWords remaining: {myScripture.WordCounter()}");

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                Environment.Exit(0);
            }

            myScripture.HideRandomWords(3);

            if (myScripture.AllWordsHidden())
            {
                Console.Clear();
                myScripture.Display();
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}