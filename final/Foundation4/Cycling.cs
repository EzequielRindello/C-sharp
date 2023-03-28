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
}