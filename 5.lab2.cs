using System;

class BankAccount
{
    public string Owner { get; set; }
    public string Number { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, string number)
    {
        Owner = owner;
        Number = number;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdraw amount must be positive");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds");
        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        var account = new BankAccount("Artur", "BA001");

        try
        {
            account.Deposit(1000);
            account.Withdraw(300);
            account.Deposit(200);
            Console.WriteLine($"Final Balance: {account.Balance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
