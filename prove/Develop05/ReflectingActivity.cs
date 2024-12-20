public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectingActivity() :base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string>(){"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    }


    public void Run()
    {
        Console.Clear();
        DisplayStaringMessage();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int r = rnd.Next(_questions.Count);
        return _questions[r];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string response = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
        ShowSpinner(6);
        Console.WriteLine();
    }


}