using System;
using System.Collections.Generic;
using System.IO;

sealed class TeamTempFiles : IDisposable
{
    private bool _disposed;
    private readonly List<string> _files = new();

    public IReadOnlyList<string> Files => _files;

    public TeamTempFiles(int count)
    {
        for (int i = 0; i < count; i++)
        {
            string path = Path.Combine(Path.GetTempPath(), $"team_tmp_{Guid.NewGuid():N}.txt");
            File.WriteAllText(path, $"Temp file #{i}");
            _files.Add(path);
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }


    {
        Dispose(false);
    }

    private void Dispose(bool disposing)
    {
        if (_disposed) return;

        try
        {
            foreach (var f in _files)
            {
                try
                {
                    if (File.Exists(f))
                        File.Delete(f);
                }
                catch { /* production-ում՝ log */ }
            }
        }
        finally
        {
            _files.Clear();
            _disposed = true;
        }
    }
}

class Program
{
    static void Main()
    {
        using (var tmp = new TeamTempFiles(count: 3))
        {
            Console.WriteLine("Created temp files:");
            foreach (var f in tmp.Files)
                Console.WriteLine(f);
        }

        Console.WriteLine("Disposed, temp files should be deleted.");
    }
}
