using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);
        string letter = "";
        string sign = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        int lastDigit = x % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (x >= 70)
        {
            Console.WriteLine("Congradulations on passing the course!");
        }
        else 
        {
            Console.WriteLine("Sorry, you did not pass the course. Maybe next time.");
        }
    }
}