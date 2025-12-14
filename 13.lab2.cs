using System;
using System.IO;

namespace Lab2_EventsWithEventHandler
{
    public sealed class TempEventArgs : EventArgs
    {
        public double Current { get; }
        public double Threshold { get; }
        public DateTime Time { get; }

        public TempEventArgs(double current, double threshold)
        {
            Current = current;
            Threshold = threshold;
            Time = DateTime.Now;
        }
    }

    public sealed class TemperatureSensor
    {
        public event EventHandler<TempEventArgs>? Overheated;

        public double Threshold { get; set; } = 80.0;

        private double _current;
        public double Current
        {
            get => _current;
            set
            {
                _current = value;
                if (_current > Threshold)
                    Overheated?.Invoke(this, new TempEventArgs(_current, Threshold));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var sensor = new TemperatureSensor { Threshold = 50.0 };

            sensor.Overheated += (sender, e) =>
            {
                Console.WriteLine($"[Overheated:Console] {e.Time:HH:mm:ss} | Current={e.Current} > Threshold={e.Threshold}");
            };

            sensor.Overheated += (sender, e) =>
            {
                File.AppendAllText("temp.log",
                    $"[Overheated:File] {e.Time:HH:mm:ss} | Current={e.Current} > Threshold={e.Threshold}{Environment.NewLine}");
            };

            sensor.Current = 30;
            sensor.Current = 55;
            sensor.Current = 49;
            sensor.Current = 80;
        }
    }
}
