public class Activity
{
    protected string _date;
    protected float _minutes;
    protected string _antivityName;

    public Activity(string date, float minutes, string antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
    }

    public Activity(string date, float minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }

    public virtual float Distance()
    {
        return 0;
    }

    public virtual float Speed()
    {
        return 0;
    }

    public virtual float Pace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_antivityName} ({_minutes})- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile";
    }
}