using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() :base ()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _count = 0;
        _prompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }



    public void run()
    {
        Console.Clear();
        DisplayStaringMessage();
        _count = GetListFromUser().Count();
        Console.WriteLine($"You have written {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }


    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[r]);
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            GetRandomPrompt();
            string response = Console.ReadLine();
            responses.Add(response);
            Console.WriteLine();
        }

        return responses;
    }
        

}