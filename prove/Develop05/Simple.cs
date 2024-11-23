class Simple : Goal
{
    public Simple() : base("", 0, "") { }

    public Simple(string name, int points, bool isComplete, string description) : base(name, points, description)
    {
        _isComplete = isComplete;
    }

    public override void CreateGoal()
    {
        Console.WriteLine("Enter name of the goal: ");
        _name = Console.ReadLine();
        Console.Write("Enter the points for completing this goal: ");
        _points = int.Parse(Console.ReadLine());
        _isComplete = false;
        Console.WriteLine("Write a short description the goal: ");
        _description = Console.ReadLine();
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;
        return _points;
    }

    public override string GetStatus()
    {
        return base.GetStatus();
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_points}|{_isComplete}|{_description}";
    }

}