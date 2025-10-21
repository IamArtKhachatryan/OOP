using System;

class LibraryBook
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    // 3-param constructor
    public LibraryBook(string title, string author, int year)
    {
        Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title.Trim();
        Author = string.IsNullOrWhiteSpace(author) ? "Unknown" : author.Trim();
        Year = (year < 1450 || year > DateTime.Now.Year) ? DateTime.Now.Year : year;
    }

    // 2-param constructor → chain to 3-param
    public LibraryBook(string title, string author) 
        : this(title, author, DateTime.Now.Year) { }

    // default constructor → chain to 2-param
    public LibraryBook() 
        : this("Untitled", "Unknown") { }

    public override string ToString() => $"{Title} by {Author} ({Year})";
}

class Program
{
    static void Main()
    {
        var b1 = new LibraryBook();  // default
        var b2 = new LibraryBook("The Hobbit", "J.R.R. Tolkien");
        var b3 = new LibraryBook("Clean Code", "Robert C. Martin", 2008);

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
    }
}
