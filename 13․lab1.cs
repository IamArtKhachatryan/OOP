using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1_DelegateBasics
{
    public delegate void Notifier(string msg);

    class Program
    {
        static readonly List<string> Memory = new();

        static void ConsoleLog(string msg)
        {
            Console.WriteLine($"[Console] {DateTime.Now:HH:mm:ss} | {msg}");
        }

        static void FileLog(string msg)
        {
            File.AppendAllText("notifier.log", $"[File] {DateTime.Now:HH:mm:ss} | {msg}{Environment.NewLine}");
        }

        static void MemoryLog(string msg)
        {
            Memory.Add($"[Memory] {DateTime.Now:HH:mm:ss} | {msg}");
        }

        static void SafeInvokeAll(Notifier notify, string msg)
        {
            foreach (var d in notify.GetInvocationList())
            {
                try
                {
                    ((Notifier)d)(msg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Handler error] {d.Method.Name}: {ex.Message}");
                }
            }
        }

        static void Main()
        {
            Notifier notify = ConsoleLog;
            notify += FileLog;
            notify += MemoryLog;

            SafeInvokeAll(notify, "Hello 1");
            SafeInvokeAll(notify, "Hello 2");

            notify -= FileLog;

            SafeInvokeAll(notify, "After removal");

            Console.WriteLine("Memory log:");
            foreach (var line in Memory)
                Console.WriteLine(line);
        }
    }
}
