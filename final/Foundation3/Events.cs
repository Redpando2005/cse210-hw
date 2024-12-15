public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    // Make a public method for variables
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // First set of details for first message
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    // Last message for short details
    public string GetShortDescription(string eventType)
    {
        return $"Type: {eventType}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}