public class Swimming : Activity
{
    public int _numberOfLaps;

    public Swimming(string date, float minutes, int laps, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._numberOfLaps = laps;
    }
    public override float Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }
}