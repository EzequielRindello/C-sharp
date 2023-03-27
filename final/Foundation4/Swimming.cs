public class Swimming : Activity
{
    public int _numberOfLaps;

    public Swimming(string date, float minutes, int laps) : base(date, minutes)
    {
        this._date = date;
        this._minutes = minutes;
        this._numberOfLaps = laps;
    }
    public override float Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }
}