using System;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers between 1 and 100 are: ");

        for (int number = 2; number <= 100; number++)
        {
            bool isPrime = true;

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }
}