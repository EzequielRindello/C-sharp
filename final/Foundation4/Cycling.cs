public class Cycling : Activity
{
    private double _speed;
    private double _bikeDistance;

    public Cycling(string date, float minutes, double speed, double bikeDistance, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._speed = speed;
        this._bikeDistance = bikeDistance;
        this._antivityName = antivityName;
    }

    public override double Distance()
    {
        return _bikeDistance;
    }

    public override double Speed()
    {
        return (_bikeDistance / _minutes) * 60;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }
}