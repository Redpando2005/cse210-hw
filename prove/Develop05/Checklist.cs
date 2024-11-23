class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public Checklist() : base("", 0, "") { }

    public Checklist(string name, int points, int currentCount, int targetCount, int bonusPoints, string description)
        : base(name, points, description)
    {
        _currentCount = currentCount;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _isComplete = _currentCount >= _targetCount;
    }


    public override void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();
        Console.Write("Enter the points for each completion: ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of times to complete this goal: ");
        _targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus points for completing all targets: ");
        _bonusPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a short description the goal: ");
        _description = Console.ReadLine();
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return _points + _bonusPoints;
        }

        return _points;
    }

    public override string GetStatus()
    {
        return $"{base.GetStatus()} (Completed {_currentCount}/{_targetCount} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_points}|{_currentCount}|{_targetCount}|{_bonusPoints}|{_description}";
    }
}