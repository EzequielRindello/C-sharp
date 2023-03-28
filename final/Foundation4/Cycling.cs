public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, float minutes, double speed, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._speed = speed;
    }

    public override double Distance()
    {
        return  0;
    }

    public override double Speed()
    {
        return 60 / (60 / _speed);
    }

    public override double Pace()
    {
        return 60 / _speed;
    }
}