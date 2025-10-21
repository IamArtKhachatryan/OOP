using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader? reader = null;
        try
        {
            reader = new StreamReader("data.txt");
            string content = reader.ReadToEnd();
            Console.WriteLine("File content:\n" + content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("Reader closed (finally block).");
            }
        }
    }
}
