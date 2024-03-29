public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public string StandardDetails()
    {
        return $"Event: {_eventTitle} | Description: {_description} | Date: {_date} | Time: {_time} | Address: {_address.GetFullAddress()}";
    }

    public void ReadKey()
    {
        Console.WriteLine();
        Console.WriteLine("Enter any key to continue when you feel ready.");
        Console.ReadKey();
    }

    public string ShortDescription()
    {
        return $"{_eventTitle} | {_date}";
    }
}