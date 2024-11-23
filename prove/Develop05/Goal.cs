public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    protected string _description;

    public string Name => _name;

    public string Description => _description;
    public bool IsComplete => _isComplete;

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public abstract int RecordEvent();

    public virtual string GetStatus()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name}";
    }

    public abstract void CreateGoal();
    
    // Returns a string representation of the goal for saving
    public abstract string GetStringRepresentation();

    // Creates a goal from a string representation
    public static Goal CreateFromString(string data)
    {
        string[] parts = data.Split('|');
        string goalType = parts[0];

        switch (goalType)
        {
            case "SimpleGoal":
                return new Simple(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]), parts[4]);
            case "EternalGoal":
                return new Eternal(parts[1], int.Parse(parts[2]), parts[3]);
            case "ChecklistGoal":
                return new Checklist(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), parts[6]);
            default:
                throw new Exception("Unknown goal type");
        }
    }
}
