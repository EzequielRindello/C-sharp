public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions()
    {
        this._eventTitle = "";
        this._description = "Require people to register beforehand";
        this._date = "27/04/23";
        this._time = "";
        Address receptionsAddress = new Address("301 W 13th St Suite 100", "Kansas City");
        receptionsAddress.GetFullAddress();
        this._address = receptionsAddress;
        this._rsvpEmail = "";
    }
}