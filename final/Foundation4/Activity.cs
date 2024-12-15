public abstract class Activity
{
    // Shared details for all activities
    private DateTime _date;
    private int _durationMinutes;

    // Constructor to set up the base details
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // Properties to access the details
    public DateTime Date => _date;
    public int DurationMinutes => _durationMinutes;

    // Methods to calculate distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to summarize the activity details
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_durationMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}