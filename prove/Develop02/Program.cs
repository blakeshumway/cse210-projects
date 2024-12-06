using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.IO; 
//journal program
class Program
{

    static void Main(string[] args)
    {
        int response;

        //get current date and store it in string
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //string timeText = theCurrentTime.toString("h:mm tt")

        Console.WriteLine(theCurrentTime);


        
        PromptGenerator thePrompts = new PromptGenerator();
        
        //make a list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("How was your day?:");
        prompts.Add("What did you eat for breakfast?:");
        prompts.Add("What did you eat for dinner?:");
        prompts.Add("Who did you talk to?:");
        prompts.Add("What did you wear?:");
        prompts.Add("Where did you go?:");
        prompts.Add("What did you read?:");
        prompts.Add("When did you wake up?:");
        prompts.Add("What was your favorite moment of the day?:");
        prompts.Add("What did you watch today?:");
        prompts.Add("What did you play today?:");


        //Console.WriteLine(prompts[1]);
        thePrompts._prompts = prompts;
        Console.WriteLine(thePrompts.GetRandomPrompt());

        //make new journal object
        Journal theJournal = new Journal();

        //loop program until the user responds with 5
        do {
        var rdm = new Random();
        int randomNumber = rdm.Next(0, 11);

        thePrompts._randomNumber = randomNumber;





     
        
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Delete Entry");


            Console.Write("What would you like to do?: ");
            string answer = Console.ReadLine();

            response = int.Parse(answer);

            //go through selection

            //write
            if (response == 1)
            {
                string entryPrompt = thePrompts.GetRandomPrompt();
                Console.WriteLine($"{entryPrompt}");
                Console.Write("");
                answer = Console.ReadLine();
                
                Entry newEntry = new Entry();

                newEntry._date = dateText;
                newEntry._promptText = entryPrompt;
                newEntry._entryText = answer;
                //add entry to the journal
                theJournal.AddEntry(newEntry);

            }

            if (response ==2)
            {
                theJournal.DisplayAll();
            }


            //load
            if (response == 3)
            {
            Console.Write("What is the name of the file?: ");
            string filename = Console.ReadLine();

            theJournal.LoadFromFile(filename);

            }


            //save
            if (response == 4)
            {
            Console.Write("What is the name of the file?: ");
            string fileName = Console.ReadLine();

            theJournal.SaveToFile(fileName);

            }

            //delete entry
            if (response == 6)
            {
                if (theJournal._entries.Count > 0)
                {
                    Console.WriteLine("Would you like to delete the last entry?: ");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.Write("");

                    answer = Console.ReadLine();
                    response = int.Parse(answer);

                    if (response == 1)
                    {
                       int lastEntry = theJournal._entries.Count - 1;

                        theJournal.DeleteEntry(lastEntry);
                    }
                    else if (response == 2)
                    {
                        Console.WriteLine("deletion cancelled");
                    }

                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else
                {
                    Console.WriteLine("There is nothing to delete");
                }

            }


     
        } while (response != 5);
    }
}