using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; }
    public int Grade { get; }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    // Sort by Grade (default)
    public int CompareTo(Student? other)
    {
        if (other == null) return 1;
        return Grade.CompareTo(other.Grade);
    }

    public override string ToString() => $"{Name} ({Grade})";
}

// Separate comparer for Name
class NameComparer : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        return string.Compare(x?.Name, y?.Name, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student("Anna", 85),
            new Student("David", 92),
            new Student("Bella", 78)
        };

        Console.WriteLine("Sorted by Grade:");
        students.Sort();
        students.ForEach(s => Console.WriteLine(s));

        Console.WriteLine("\nSorted by Name:");
        students.Sort(new NameComparer());
        students.ForEach(s => Console.WriteLine(s));
    }
}
