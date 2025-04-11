using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        //Creates the fractions
        Fraction fraction1 = new Fraction(); //1/1

        Fraction fraction2 = new Fraction(6); //6/1
        
        Fraction fraction3 = new Fraction(6, 7); //6/7

        //This is how you set new values using the setters: 
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        fraction2.SetTop(8);
        fraction2.SetBottom(5);

        fraction3.SetTop(9);
        fraction3.SetBottom(2);

        //This is how you get the fractions.
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetFractionString()}");
    }
}