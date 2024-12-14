using System;

class Program
{

    //To show creativity, since a lot of this assignment is about entering time and waiting, I made it so the program keeps track of
    //and displays the total amount of time the user has spent using the program once the user chooses the quit option.
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity();
        ReflectingActivity activity2 = new ReflectingActivity();
        ListingActivity activity3 = new ListingActivity();
        
        DateTime startTime = DateTime.Now;

        int answer = 0;
        while (answer != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu");

            string response = Console.ReadLine();

            answer = int.Parse(response);

            if (answer == 1)
            {
                activity1.Run();
            }
            else if (answer == 2)
            {
                activity2.Run();
            }
            else if (answer == 3)
            {
                activity3.Run();
            }


        DateTime endTime = DateTime.Now;

        Console.WriteLine($"You used this program for {endTime.Minute - startTime.Minute} minutes");



        }






    }
}