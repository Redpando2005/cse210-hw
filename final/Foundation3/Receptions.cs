public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Everything in first message as well as reception specific info
    public string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}