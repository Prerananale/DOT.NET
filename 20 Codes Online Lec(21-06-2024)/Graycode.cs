using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 3; 
        List<string> grayCodes = GenerateGrayCode(n);

        Console.WriteLine("Gray Codes for {0} bits:", n);
        foreach (string code in grayCodes)
        {
            Console.WriteLine(code);
        }
    }

    static List<string> GenerateGrayCode(int n)
    {
        if (n <= 0)
        {
            return new List<string> { "0" };
        }

        if (n == 1)
        {
            return new List<string> { "0", "1" };
        }

        List<string> previousGrayCodes = GenerateGrayCode(n - 1);
        List<string> newGrayCodes = new List<string>();

        foreach (string code in previousGrayCodes)
        {
            newGrayCodes.Add("0" + code);
        }

        for (int i = previousGrayCodes.Count - 1; i >= 0; i--)
        {
            newGrayCodes.Add("1" + previousGrayCodes[i]);
        }

        return newGrayCodes;
    }
}