using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        while (userNumber != 0) {

        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        userNumber = int.Parse(number);

        if (userNumber != 0)
        {
        numbers.Add(userNumber);
        }

        }
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = ((float)sum) / numbers.Count;

        int maxNumber = 0;

        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}