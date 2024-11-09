using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        Console.WriteLine($"What is the magic number? {magicNumber}");

        //int guess;
        
        Console.Write($"What is your guess? ");

        string response = Console.ReadLine();
        int guess = int.Parse(response);
        
        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }       
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        
    }
}