using System;
using System.Collections.Generic;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car drives on the road.");
    }
}

class Human : IMovable
{
    public void Move()
    {
        Console.WriteLine("Human walks on foot.");
    }
}

class Robot : IMovable
{
    public void Move()
    {
        Console.WriteLine("Robot rolls forward on tracks.");
    }
}

class Program
{
    static void Main()
    {
        var movables = new List<IMovable>
        {
            new Car(),
            new Human(),
            new Robot()
        };

        foreach (var m in movables)
            m.Move();
    }
}
