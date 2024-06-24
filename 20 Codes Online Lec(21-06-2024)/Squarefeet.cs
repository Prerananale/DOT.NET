using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Square Footage Calculator for a House");

        Console.Write("Enter the length of the house (in feet): ");
        string lengthInput = Console.ReadLine();
        double length;
        if (!double.TryParse(lengthInput, out length) || length <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive numeric value for the length.");
            return;
        }
        Console.Write("Enter the width of the house (in feet): ");
        string widthInput = Console.ReadLine();
        double width;
        if (!double.TryParse(widthInput, out width) || width <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive numeric value for the width.");
            return;
        }

         double squareFeet = length * width;

        Console.WriteLine("The square footage of the house is: {0} square feet", squareFeet);
    }
}