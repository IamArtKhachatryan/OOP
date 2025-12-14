using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollectionSystem
{
    public sealed class Student
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public double Gpa { get; init; }
        public int Age { get; init; }

        public override string ToString() => $"{Id}: {Name} (GPA={Gpa}, Age={Age})";
    }

    public sealed class StudentCollection : IEnumerable<Student>
    {
        private readonly List<Student> _items = new();

        public int Count => _items.Count;

        public Student this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public void Add(Student s)
        {
            if (s is null) throw new ArgumentNullException(nameof(s));
            _items.Add(s);
        }

        public bool RemoveById(int id)
        {
            int idx = _items.FindIndex(x => x.Id == id);
            if (idx < 0) return false;
            _items.RemoveAt(idx);
            return true;
        }

        public IEnumerator<Student> GetEnumerator() => _items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static StudentCollection operator +(StudentCollection a, StudentCollection b)
        {
            if (a is null) throw new ArgumentNullException(nameof(a));
            if (b is null) throw new ArgumentNullException(nameof(b));

            var merged = new StudentCollection();
            foreach (var s in a) merged.Add(s);
            foreach (var s in b) merged.Add(s);
            return merged;
        }

        public static implicit operator List<Student>(StudentCollection c)
        {
            if (c is null) throw new ArgumentNullException(nameof(c));
            return c._items.ToList();
        }
    }

    public static class StudentExtensions
    {
        public static string ToCsvString(this IEnumerable<Student> src)
        {
            if (src is null) throw new ArgumentNullException(nameof(src));

            var sb = new StringBuilder();
            sb.AppendLine("Id,Name,Gpa,Age");

            foreach (var s in src)
            {
                string name = EscapeCsv(s.Name);
                sb.AppendLine($"{s.Id},{name},{s.Gpa},{s.Age}");
            }

            return sb.ToString();
        }

        private static string EscapeCsv(string s)
        {
            s ??= "";
            bool needsQuotes = s.Contains(',') || s.Contains('"') || s.Contains('\n') || s.Contains('\r');
            if (!needsQuotes) return s;
            return "\"" + s.Replace("\"", "\"\"") + "\"";
        }
    }

    class Program
    {
        static void Main()
        {
            var groupA = new StudentCollection();
            groupA.Add(new Student { Id = 1, Name = "Artur", Gpa = 3.6, Age = 20 });
            groupA.Add(new Student { Id = 2, Name = "Mariam", Gpa = 3.9, Age = 19 });

            var groupB = new StudentCollection();
            groupB.Add(new Student { Id = 3, Name = "Arman", Gpa = 2.8, Age = 22 });
            groupB.Add(new Student { Id = 4, Name = "Ani, Jr.", Gpa = 3.2, Age = 21 });

            var all = groupA + groupB;

            Console.WriteLine("Indexer demo:");
            Console.WriteLine(all[0]);
            all[0] = new Student { Id = 10, Name = "Updated Student", Gpa = 3.1, Age = 20 };
            Console.WriteLine(all[0]);

            List<Student> asList = all;
            Console.WriteLine($"\nImplicit to List<Student>: Count = {asList.Count}");

            Console.WriteLine("\nCSV output:");
            Console.WriteLine(all.ToCsvString());

            Console.WriteLine("LINQ query -> anonymous type:");
            var report =
                from s in all
                where s.Gpa >= 3.2
                orderby s.Gpa descending
                select new
                {
                    s.Id,
                    UpperName = s.Name.ToUpperInvariant(),
                    Level = s.Gpa >= 3.7 ? "Excellent" : "Good",
                    NextYearAge = s.Age + 1
                };

            foreach (var r in report)
                Console.WriteLine($"{r.Id} | {r.UpperName} | {r.Level} | NextYearAge={r.NextYearAge}");
        }
    }
}
