using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("☆ SANJIVANI COLLEGE OF ENGINEERING");
        Console.WriteLine("~ Academic Fees Receipt ~");
        Console.WriteLine("Name: Prerana");
        Console.WriteLine("USTN: ******");
        Console.WriteLine("BRANCH: IT, OR CSE");
        Console.WriteLine("Year/Sem: 2024-2025/1st Sem");
        Console.WriteLine("Date: 19/06/1990");
        Console.WriteLine("Time: 11:45 AM");
        Console.WriteLine("1) Entrance");
        Console.WriteLine("2) Exams");
        Console.WriteLine("3) Library");
        Console.WriteLine("4) Hostel");
        Console.WriteLine("5) Laboratory");
        Console.WriteLine("6) Projects & Classes");
        
        Console.Write("Enter the amount: ₹");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        
        decimal grandTotal = amount + (amount * 0.18m);
        
        Console.WriteLine("Total: ₹" + amount);
        Console.WriteLine("GRAND TOTAL ₹ = " + grandTotal + " (+ 18% GSP)");
        Console.ReadLine();
    }
}