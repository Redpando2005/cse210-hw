public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0; // Keep track of the user's total points

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose a goal type to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new Simple();
                break;
            case "2":
                newGoal = new Eternal();
                break;
            case "3":
                newGoal = new Checklist();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        newGoal.CreateGoal();
        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    //asks the user for the filename and saves the list of goals
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals to: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    //will bring in all goals from chosen filename
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }

        _goals.Clear(); // Clear the existing list of goals
        foreach (var line in File.ReadAllLines(filename))
        {
            _goals.Add(Goal.CreateFromString(line));
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    //shows current goals
    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }

    public void RecordGoalCompletion()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record. Create a goal first.");
            return;
        }

        Console.WriteLine("\nWhich goal did you complete?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }

        Console.Write("Enter the number of the completed goal: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            var selectedGoal = _goals[choice - 1];
            int earnedPoints = selectedGoal.RecordEvent();

            if (earnedPoints > 0)
            {
                _totalPoints += earnedPoints;
                Console.WriteLine($"You earned {earnedPoints} points! Total score: {_totalPoints}");
            }
            else
            {
                Console.WriteLine("This goal is already completed or cannot be completed further.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

}