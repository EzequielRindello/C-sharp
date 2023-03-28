public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, double distance, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double Pace()
    {
        return _minutes / _distance;
    }

}