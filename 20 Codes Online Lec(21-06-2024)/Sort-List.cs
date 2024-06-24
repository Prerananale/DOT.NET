using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> names = new List<string>();

        Console.Write("How many names would you like to enter? ");
        int numberOfNames;
        numberOfNames=Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfNames; i++)
        {
            Console.Write("Enter name "+(i + 1)+": ");
            names.Add(Console.ReadLine());
        }
        Console.WriteLine("Before Sorting:");
        foreach (string name in names)
        {
            Console.Write(name+" ");
        }

        names.Sort();
        Console.WriteLine("\nNames in alphabetical order:");
        foreach (string name in names)
        {
            Console.Write(name+" ");
        }
    }
}