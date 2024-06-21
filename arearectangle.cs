using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        Console.WriteLine("Enter the Length of a Rectangle: ");
        double Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Breadth of a Rectangle: ");
        double Breadth = Convert.ToInt32(Console.ReadLine());

        double Area = Length * Breadth;
        Console.WriteLine("Area of Rectangle is" +Area);
        Console.ReadKey();
    }
}