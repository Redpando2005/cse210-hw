public class Cycling : Activity
{
    private double _speedKph;

    // Constructor to set up Cycling-specific details
    public Cycling(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        _speedKph = speedKph;
    }

    // Calculations for Cycling
    public override double GetDistance() => (_speedKph * DurationMinutes) / 60;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60 / GetSpeed();

    // Summary specific to Cycling
    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Cycling ({DurationMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}