public class Running : Activity
{
    private double _distanceKm;

    // Constructor to set up Running-specific details
    public Running(DateTime date, int durationMinutes, double distanceKm)
        : base(date, durationMinutes)
    {
        _distanceKm = distanceKm;
    }

    // Calculations for Running
    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes / GetDistance();

    // Summary specific to Running
    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Running ({DurationMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}