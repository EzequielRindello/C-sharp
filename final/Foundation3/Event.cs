public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event()
    {
        _eventTitle = "";
        _description = "";
        _date = "";
        _time = "";
        _address = "";
    }

    public string StandardDetails()
    {
        return $"Event: {_eventTitle} | Description: {_description} | Date: {_date} | Time: {_time} | Address:{_address}";
    }
}