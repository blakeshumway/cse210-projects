using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether", 12, 12);
        Scripture scripture = new Scripture(reference, "For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith.");
        string answer = "";


        do
        {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Press Enter to continue or type 'quit to finish: ");
        Console.Write("");
        answer = Console.ReadLine();

        if (scripture.IsCompletelyHidden() == true)
        {
            answer = "quit";
        }
        else if (answer != "quit")
        {
            Random r = new Random();
            int random = r.Next(0, 27);
            scripture.HideRandomWords(random);

        }   
        } while (answer != "quit");



    }
}