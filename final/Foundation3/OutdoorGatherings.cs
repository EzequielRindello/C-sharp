public class OutdoorGatherings : Event
{
    private string _statementOfTheWeather;

    public OutdoorGatherings(string date, string time, string statementOfTheWeather)
    {
        this._eventTitle = "Outdoor Gatherings";
        this._description = "Dont have a limit on attendees";
        this._date = date;
        this._time = time;
        Address outdoorGatheringsAddress = new Address("301 W 13th St Suite 100", "Kansas City");
        outdoorGatheringsAddress.GetFullAddress();
        this._address = outdoorGatheringsAddress;
        this._statementOfTheWeather = statementOfTheWeather;
    }

    public void OutdoorGatheringsDetails()
    {
        Console.WriteLine($"The Statement of theWeather  will be {_statementOfTheWeather}");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Outdoor events are conditioned by the weather.");
        Console.WriteLine("These types of events do not have a capacity for guests, feel free to attend!");
        StandardDetails();
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
    }
}