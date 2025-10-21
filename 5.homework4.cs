using System;

class AppSettings
{
    public string Environment { get; init; }
    public string Version { get; init; }

    public override string ToString()
        => $"Environment={Environment}, Version={Version}";
}

class Program
{
    static void Main()
    {
        var settings = new AppSettings
        {
            Environment = "Prod",
            Version = "1.2.0"
        };

        Console.WriteLine(settings);
    }
}
