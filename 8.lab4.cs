using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new Exception("DB connection failed");
        }
        catch (Exception ex) when (ex.Message.Contains("DB"))
        {
            Console.WriteLine($"Database-related error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Other error: {ex.Message}");
        }
    }
}
