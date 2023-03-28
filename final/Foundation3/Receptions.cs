public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string date, string time, string rsvpEmail, Address receptionsAddress)
    {
        this._eventTitle = "Receptions";
        this._description = "Require people to register beforehand";
        this._date = date;
        this._time = time;
        this._address = receptionsAddress;
        this._rsvpEmail = rsvpEmail;
    }

    public void ReceptionsDetails()
    {
        Console.WriteLine($"The RSVP mail for this session will be {_rsvpEmail}");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("These types of events require registration in advance.");
        Console.WriteLine("The email provided is to do it in a timely manner, it is expected to register at least 10 days before the event");
        Console.WriteLine(StandardDetails());
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
    }
}