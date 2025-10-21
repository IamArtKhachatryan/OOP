using System;

class Email
{
    private string address;

    public Email(string? address)
    {
        if (address == null)
            throw new ArgumentNullException(nameof(address));

        this.address = Normalize(address);

        if (!IsValid())
            throw new ArgumentException("Invalid email address");
    }

    private string Normalize(string addr) => addr.Trim().ToLowerInvariant();

    public bool IsValid() => address.Contains('@');

    public override string ToString() => address;
}

class Program
{
    static void Main()
    {
        var email = new Email("  Test@Example.Com  ");
        Console.WriteLine(email);
    }
}
