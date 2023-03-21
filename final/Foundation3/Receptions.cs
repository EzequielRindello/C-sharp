public class Receptions : Event
{
    private string _email;
    private bool _rsvp;

    public Receptions()
    {
        this._eventTitle = "";
        this._description = "";
        this._date = "";
        this._time = "";
        this._address = "";
        this._email = "";
        this._rsvp = false;
    }
}