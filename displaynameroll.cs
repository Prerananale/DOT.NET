using System;

public class BoxingUnboxingExample
{
    public static void Main(string[] args)
    {
      
        string name = "Prerana Nale";
        int rollNumber = 72;

        object boxedName = name;
        object boxedRollNumber = rollNumber;

        Console.WriteLine("Boxed Name: {0}", boxedName);
        Console.WriteLine("Boxed Roll Number: {0}", boxedRollNumber);

        string unboxedName = (string)boxedName;
        int unboxedRollNumber = (int)boxedRollNumber;

        Console.WriteLine("Unboxed Name: {0}", unboxedName);
        Console.WriteLine("Unboxed Roll Number: {0}", unboxedRollNumber);
    }
}