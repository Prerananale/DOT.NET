using System;
public class AreaOfTriangle
{
    public static void Main()
    {
        Console.Write("Enter the Base:");
        double Base = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Height:");
        double Height = Convert.ToDouble(Console.ReadLine());
        
        double Area = (Base * Height) / 2;

        Console.Write("Area of a Triangle = " + Area);
        Console.ReadKey();
    }
}