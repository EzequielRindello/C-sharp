public class Running : Activity
{
    private float _distance;

    public Running(string date, float minutes, float distance, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._distance = distance;
    }

    public override float Speed()
    {
        return (_distance / _minutes) * 60;
    }

    public override float Distance()
    {
        return _distance;
    }
}