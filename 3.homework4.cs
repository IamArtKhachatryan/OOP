using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // 1 to 100
        int guess = 0;

        Console.WriteLine("Guess the number between 1 and 100!");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < secretNumber)
                Console.WriteLine("Too low!");
            else if (guess > secretNumber)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct! You guessed the number.");
        }
    }
}
