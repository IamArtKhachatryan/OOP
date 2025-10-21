using System;

interface IFoo
{
    void DoWork();
}

interface IBar
{
    void DoWork();
}

class Worker : IFoo, IBar
{
    void IFoo.DoWork()
    {
        Console.WriteLine("Doing work as IFoo");
    }

    void IBar.DoWork()
    {
        Console.WriteLine("Doing work as IBar");
    }
}

class Program
{
    static void Main()
    {
        var w = new Worker();

        ((IFoo)w).DoWork(); // Calls IFoo version
        ((IBar)w).DoWork(); // Calls IBar version
    }
}
