public class OutdoorGatherings : Event
{
    private string _statementOfTheWeather;

    public OutdoorGatherings()
    {
        this._eventTitle = "Outdoor Gatherings";
        this._description = "Dont have a limit on attendees";
        this._date = "29/04/23";
        this._time = "12 P.M";
        Address outdoorGatheringsAddress = new Address("301 W 13th St Suite 100", "Kansas City");
        outdoorGatheringsAddress.GetFullAddress();
        this._address = outdoorGatheringsAddress;
        this._statementOfTheWeather = "Sunny";
    }

    public  void OutdoorGatheringsDetails()
    {

    }
}