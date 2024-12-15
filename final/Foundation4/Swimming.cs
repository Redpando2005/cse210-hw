public class Swimming : Activity
{
    private int _laps;

    // Constructor to set up Swimming-specific details
    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        _laps = laps;
    }

    // Calculations for Swimming
    public override double GetDistance() => (_laps * 50) / 1000.0;
    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;
    public override double GetPace() => DurationMinutes / GetDistance();

    // Summary specific to Swimming
    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({DurationMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}