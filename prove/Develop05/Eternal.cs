class Eternal : Goal
{
    public Eternal() : base("", 0, "") { }

    public Eternal(string name, int points, string description) : base(name, points, description) { }

    public override void CreateGoal()
    {
        Console.WriteLine("Enter name of the goal: ");
        _name = Console.ReadLine();
        Console.Write("Enter the points for completing this goal: ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a short description the goal: ");
        _description = Console.ReadLine();
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStatus()
    {
        return $"[∞] {_name}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_points}|{_description}";
    }

}