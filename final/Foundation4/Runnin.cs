public class Running : Activity
{
    private float _distance;

    public Running(string date, float time, float distance) : base(date, time)
    {
        this._date = date;
        this._time = time;
        this._distance = distance;
    }

    public override float Distance()
    {
        return _distance;
    }
    public override string Summary()
    {
        return $"{_date} Running ({_time})- Distance {_distance}, Speed 6.0 mph, Pace: 10.0 min per mile";
    }
}