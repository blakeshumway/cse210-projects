using System;

class Program
{
    static void Main(string[] args)
    {
        //this line prints a sentence and awaits a response
        Console.Write("What is your grade percentage? ");

        //this line taks the answer from the last line and converts it into a string
        string answer = Console.ReadLine();

        //this line takes takes the string stored in "answer" and converts it into an int and stores it into the percent var
        int percentage = int.Parse(answer);


        //this creates a new string to use as a response
        string grade = "";

        //This goes through checks to determine the appropriate letter grade
        if (percentage >= 90)
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }

        else if (percentage >= 70)
        {
            grade = "C";
        }

        else if (percentage >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }


        //now that we have the letter grade we print it out with this line
        Console.WriteLine($"Your grade is: {grade}");
        

        //if percentage is lower than 70 print you failed
        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You Failed.");
        }
    }
}