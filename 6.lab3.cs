using System;

class BankAccount
{
    private static int totalAccounts;
    public static int TotalAccounts => totalAccounts;

    public string Owner { get; set; }
    public string Number { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, string number)
    {
        Owner = owner;
        Number = number;
        Balance = 0;
        totalAccounts++;
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

    public override string ToString()
        => $"{Owner} ({Number}) — Balance: {Balance}";
}

class Program
{
    static void Main()
    {
        var acc1 = new BankAccount("Artur", "A001");
        var acc2 = new BankAccount("Anna", "A002");

        acc1.Deposit(500);
        acc1.Withdraw(200);
        acc2.Deposit(1000);

        Console.WriteLine(acc1);
        Console.WriteLine(acc2);
        Console.WriteLine($"Total accounts: {BankAccount.TotalAccounts}");
    }
}
