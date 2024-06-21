using System;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age==18){
                Console.WriteLine("Allow for Voter Card");
            }
            else if(age!=18){
                Console.WriteLine("Not allow for Voter card");
            }
        }
    }
}