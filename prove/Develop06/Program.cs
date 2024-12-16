using System;

class Program
{
    //to exceed the requirements I made it so you can't load an additional list of goals from a file if you have either made a goal or if you have already loaded a file.
    //doing this help prevent the user from messing up their score and merging lists.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}