using System;
using System.Collections.Generic;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Some animal sound...");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cow says: Moo!");
    }
}

class Program
{
    static void Main()
    {
        var animals = new List<Animal>
        {
            new Dog(),
            new Cat(),
            new Cow()
        };

        foreach (var a in animals)
            a.Speak();
    }
}
