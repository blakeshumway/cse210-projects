using System.IO; 

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;


    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {   
        int userInput = 0;
        while (userInput != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create new goal");
            Console.WriteLine(" 2. List goals");
            Console.WriteLine(" 3. Save goals");
            Console.WriteLine(" 4. Load goals");
            Console.WriteLine(" 5. Record goals");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            userInput = int.Parse(response);
            Console.WriteLine();
            if (userInput == 1)
            {
                CreateGoal();
            }
            if (userInput == 2)
            {
                ListGoalDetails();
            }
            if (userInput == 3)
            {
                SaveGoals();
            }
            if (userInput == 4)
            {
                LoadGoals();
            }
            if (userInput == 5)
            {
                RecordEvent();
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");   
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine($"The types of Goals are:");
        Console.WriteLine($" 1. Simple Goal");
        Console.WriteLine($" 2. Eternal Goal");
        Console.WriteLine($" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string response = Console.ReadLine();
        int answer = int.Parse(response);

        if (answer == 1)
        {
            Console.Write("What is the name of your goal? "); 
            response = Console.ReadLine();
            string name = response;

            Console.Write("Give a short description of it: "); 
            response = Console.ReadLine();
            string description = response;
            Console.Write("How many points should this goal have? "); 
            response = Console.ReadLine();
            int points = int.Parse(response);
            SimpleGoal sg = new SimpleGoal(name, description, points);
            _goals.Add(sg);
        }
        if (answer == 2)
        {
            Console.Write("What is the name of your goal? "); 
            response = Console.ReadLine();
            string name = response;

            Console.Write("Give a short description of it: "); 
            response = Console.ReadLine();
            string description = response;
            Console.Write("How many points should this goal have? "); 
            response = Console.ReadLine();
            int points = int.Parse(response);
            EternalGoal eg = new EternalGoal(name, description, points);
            _goals.Add(eg);
        }
        if (answer == 3)
        {
            Console.Write("What is the name of your goal? "); 
            response = Console.ReadLine();
            string name = response;
            Console.Write("Give a short description of it: "); 
            response = Console.ReadLine();
            string description = response;
            Console.Write("How many points should this goal have? "); 
            response = Console.ReadLine();
            int points = int.Parse(response);
            Console.Write("How many times do you need to accomplish this goal to get a bonus? "); 
            response = Console.ReadLine();
            int target = int.Parse(response);
            Console.Write("How many bonus points should you get? "); 
            response = Console.ReadLine();
            int bonus = int.Parse(response);

            ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cg);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? "); 
        string response = Console.ReadLine();
        int index = int.Parse(response) - 1;

        int points = _goals[index].RecordEvent();

        Console.WriteLine($"Congrats! You have earned {points} points");
        _score += points;

        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            outputFile.WriteLine($"Points,{_score}");
            foreach (Goal goal in _goals)

            outputFile.WriteLine($"{goal.GetStringRepresentation()}");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "Points")
            {
                _score += int.Parse(parts[1]);

            }
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(sg);
            } 
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eg);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(cg);
            }



        }

    }



}