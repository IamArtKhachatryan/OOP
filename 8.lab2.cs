using System;

class InvalidGradeException : Exception
{
    public InvalidGradeException(string message) : base(message) { }
}

class Program
{
    static void CheckGrade(int grade)
    {
        if (grade < 0 || grade > 100)
            throw new InvalidGradeException($"Invalid grade: {grade}");
        Console.WriteLine($"Valid grade: {grade}");
    }

    static void Main()
    {
        try
        {
            CheckGrade(95);
            CheckGrade(150); // invalid
        }
        catch (InvalidGradeException ex)
        {
            Console.WriteLine($"Custom exception caught: {ex.Message}");
        }
    }
}
