using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        string input = Console.ReadLine();
        double celsius;
        if (double.TryParse(input, out celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            
            Console.WriteLine("{0}°C is equal to {1}°F", celsius, fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}