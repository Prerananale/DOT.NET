using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the  number:");
      int num = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(num > 50 && num < 80);

      }
      
    
  }
}