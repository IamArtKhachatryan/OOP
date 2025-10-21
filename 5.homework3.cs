using System;

class LibraryBook
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    public LibraryBook(string title, string author, int year)
    {
        Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title.Trim();
        Author = string.IsNullOrWhiteSpace(author) ? "Unknown" : author.Trim();
        if (year < 1450 || year > DateTime.Now.Year)
            throw new ArgumentOutOfRangeException(nameof(year));
        Year = year;
    }

    public LibraryBook(string title, string author) : this(title, author, DateTime.Now.Year) { }

    public LibraryBook(string title) : this(title, "Unknown") { }

    public override string ToString() => $"{Title} by {Author} ({Year})";
}

class Program
{
    static void Main()
    {
        var b1 = new LibraryBook("Clean Code", "Robert C. Martin", 2008);
        var b2 = new LibraryBook("The Pragmatic Programmer", "Andrew Hunt");
        var b3 = new LibraryBook("Mystery Book");

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
    }
}
