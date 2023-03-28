public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, double minutes, int laps, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._numberOfLaps = laps;
    }

    public override double Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double Speed()
    {
        return _numberOfLaps / _minutes * 60;
    }

    public override double Pace()
    {
        return _minutes / _numberOfLaps;
    }
}