using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "John",
            "Alice",
            "Bob",
            "Catherine",
            "Diana"
        };

        Console.WriteLine("Original list of names:");
        foreach (string name in names)
        {
            Console.Write(name + " ");
        }

        names.Sort();

        Console.WriteLine("\nSorted list of names:");
        foreach (string name in names)
        {
            Console.Write(name + " ");
        }
    }
}
