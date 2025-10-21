using System;

enum UserRole
{
    Admin,
    Editor,
    Viewer
}

class Program
{
    static void Main()
    {
        Console.Write("Enter role (Admin, Editor, Viewer): ");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, out UserRole role))
        {
            Console.WriteLine(GetPermission(role));
        }
        else
        {
            Console.WriteLine("Invalid role!");
        }
    }

    static string GetPermission(UserRole role)
    {
        switch (role)
        {
            case UserRole.Admin:
                return "Full access to all settings.";
            case UserRole.Editor:
                return "Can edit content.";
            case UserRole.Viewer:
                return "Can only view content.";
            default:
                return "Unknown role.";
        }
    }
}
