using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    //display welcoem message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //get username
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    //get favortie number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");

        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);

     return favoriteNumber;
    }

    //square a number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    //display the final message
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}