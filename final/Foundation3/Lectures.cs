public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures()
    {
        this._eventTitle = "Lectures";
        this._description = "Have a speaker and limited capacity";
        this._date = "08/04/23";
        this._time = "19 P.M";
        Address lecturesAddress = new Address("301 W 13th St Suite 100", "Kansas City");
        lecturesAddress.GetFullAddress();
        this._address = lecturesAddress;
        this._speakerName = "Mel Robbins";
        this._capacity = 300;
    }
    // The High 5 Habit is the book
    public  void LecturesDetails()
    {

    }
}