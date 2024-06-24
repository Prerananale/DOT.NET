using System;

class Program
{
    static void Main(string[] args)
    {
        
        decimal balance = 1000.00m;

        Console.WriteLine("Initial balance: $" + balance);

        
        Deposit(ref balance, 250.00m);
        Console.WriteLine("Balance after deposit: $" + balance);

        
        Withdraw(ref balance, 300.00m);
        Console.WriteLine("Balance after withdrawal: $" + balance);
    }

    
    static void Deposit(ref decimal accountBalance, decimal amount)
    {
        accountBalance += amount;
        Console.WriteLine("Deposited: $" + amount);
    }

    
    static void Withdraw(ref decimal accountBalance, decimal amount)
    {
        if (amount <= accountBalance)
        {
            accountBalance -= amount;
            Console.WriteLine("Withdrew: $" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds to withdraw: $" + amount);
        }
    }
}
