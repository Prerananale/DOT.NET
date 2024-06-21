using System;
class Program
{
    static void Main(string[] args)
    {
        int counter = 0;

        while (true)
        {
            counter++;

            if (counter == 5)
            {
                goto Found;
            }
            else{
                Console.WriteLine("This line will if counter!=5 be printed.");
            }
        }
        Found:
        Console.WriteLine("Counter reached 5!");
    }
}
