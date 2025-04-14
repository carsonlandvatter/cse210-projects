using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;

        while (menuChoice != 4)
        {
            Console.Write("\nMenu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\n Select a choice from the menu: ");
            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                BreathingActivity breathingActivity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.", 0);
                breathingActivity1.DisplayStartingMessage();
                breathingActivity1.ShowSpinner(3);
                Console.WriteLine();
                breathingActivity1.Run();
                breathingActivity1.DisplayEndingMessage();
            }
            else if (menuChoice == 2)
            {
                ReflectingActivity reflectingActivity1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown stength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflectingActivity1.DisplayStartingMessage();
                reflectingActivity1.ShowSpinner(3);
                Console.WriteLine();
                reflectingActivity1.Run();
                reflectingActivity1.DisplayEndingMessage();
            }
            else if (menuChoice == 3)
            {
                ListingActivity listingActivity1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                listingActivity1.DisplayStartingMessage();
                listingActivity1.ShowSpinner(3);
                Console.WriteLine();
                listingActivity1.Run();
                listingActivity1.DisplayEndingMessage();
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for taking the time out of your day for mindfulness. Hope to see you again soon.");
            }
            else
            {
                Console.WriteLine("Sorry. That was not a menu option. Please try again.");
            }
        }
    }
}