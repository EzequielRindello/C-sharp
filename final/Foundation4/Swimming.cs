public class Swimming : Activity
{
    public int _numberOfLaps;

    public Swimming(string date, float time, int laps) : base(date, time)
    {
        this._date = date;
        this._time = time;
        this._numberOfLaps = laps;
    }
    public override float Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }
}