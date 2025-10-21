using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            try
            {
                var data = File.ReadAllText("nonexistent.txt");
            }
            catch (FileNotFoundException ex)
            {
                // Re-throw as ApplicationException with inner exception
                throw new ApplicationException("Failed to load configuration file.", ex);
            }
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine($"Outer Exception: {ex.Message}");
            Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
        }
    }
}
