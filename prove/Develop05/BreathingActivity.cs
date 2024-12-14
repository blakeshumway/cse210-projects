public class BreathingActivity : Activity
{

    public BreathingActivity() :base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking through breathing in and out slowly. clear your mind and focus on your breathing.";
    }



    public void Run()
    {
        DisplayStaringMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("breath out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }
            DisplayEndingMessage();
            Console.Clear();
    }
}