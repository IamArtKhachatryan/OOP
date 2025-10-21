using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Invalid name");
        if (age <= 0)
            throw new ArgumentOutOfRangeException(nameof(age));
        Name = name;
        Age = age;
    }

    public override string ToString() => $"{Name} ({Age} y/o)";
}

class Course
{
    public string Title { get; }
    public int Credits { get; }

    public Course(string title, int credits)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Invalid title");
        if (credits < 1 || credits > 15)
            throw new ArgumentOutOfRangeException(nameof(credits), "Credits must be between 1 and 15");
        Title = title;
        Credits = credits;
    }

    public override string ToString() => $"{Title} ({Credits} credits)";
}

class Enrollment
{
    public Student Student { get; }
    public Course Course { get; }
    public DateTime EnrolledAt { get; }

    public Enrollment(Student student, Course course)
    {
        Student = student ?? throw new ArgumentNullException(nameof(student));
        Course = course ?? throw new ArgumentNullException(nameof(course));
        EnrolledAt = DateTime.Now;
    }

    public override string ToString() => $"{Student} → {Course} @ {EnrolledAt:g}";
}

class Program
{
    static void Main()
    {
        var s1 = new Student("Artur", 22);
        var s2 = new Student("Anna", 20);

        var c1 = new Course("OOP", 6);
        var c2 = new Course("Databases", 4);

        var enrollments = new List<Enrollment>
        {
            new Enrollment(s1, c1),
            new Enrollment(s2, c2),
            new Enrollment(s1, c2)
        };

        foreach (var e in enrollments)
            Console.WriteLine(e);
    }
}
