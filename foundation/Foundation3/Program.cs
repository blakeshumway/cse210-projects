using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        CyclingActivity activity1 = new CyclingActivity("12 Dec 2022", 60, 20);
        activities.Add(activity1);
        RunningActivity activity2 = new RunningActivity("03 Nov 2022", 30, 6);
        activities.Add(activity2);
        SwimmingActivity activity3 = new SwimmingActivity("03 Nov 2022", 30, 25);
        activities.Add(activity3);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}