using System;

public class BankAccount
{
    public double Balance;

    // Constructor to initialize the balance
    public BankAccount(double balance)
    {
        Balance = balance;
    }

    // Overload + operator for deposit
    public static BankAccount operator +(BankAccount account, double deposit)
    {
        account.Balance += deposit;
        Console.WriteLine( "Balance:$" + account.Balance);
        return account;
    }

    // Overload - operator for withdrawal
    public static BankAccount operator -(BankAccount account, double withdraw)
    {
        if (withdraw > account.Balance)
        {
            Console.WriteLine("Insufficient balance for withdrawal!");
        }
        else
        {
            account.Balance -= withdraw;
            Console.WriteLine( "Balance:$" +account.Balance);
        }
        return account;
    }

    // Method to display the current balance
    public void Print()
    {
        Console.WriteLine("Current Balance:$" + Balance );
    }
}

class Program
{
    static void Main()
    {
        // Initialize account with a balance of 500
        BankAccount account = new BankAccount(500);
        
        // Display initial balance
        account.Print();

        // Deposit 300 tk using overloaded + operator
        account = account + 300;

        // Withdraw 600 tk using overloaded - operator
        account = account - 600;
    }
}
