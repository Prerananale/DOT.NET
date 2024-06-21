using System;

public class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i;
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter elements for array:");

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Original array:");
        PrintArray(array);
        Console.WriteLine("Enter element to search:");
        int target = Convert.ToInt32(Console.ReadLine());
        int index = Search(array, target);
        if(index>=0)
        {
            Console.WriteLine("Element is found at index:"+index);
        }
        else{
            Console.WriteLine("Element NOT FOUND.");
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}