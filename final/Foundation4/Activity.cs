public class Activity
{
    protected string _date;
    protected double _minutes;
    protected string _antivityName;

    public Activity(string date, double minutes, string antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
    }

    public virtual double Distance()
    {
        return 0;
    }

    public virtual double Speed()
    {
        return 0;
    }

    public virtual double Pace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_antivityName} ({_minutes})- Distance {Distance()} km, Speed {Speed()} kph, Pace: {Pace()} min per km";
    }
}