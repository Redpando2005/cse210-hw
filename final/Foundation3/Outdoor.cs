public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // Everything in first message as well as outdoor specific info
    public string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Outdoor Gathering\nWeather: {_weather}";
    }
}