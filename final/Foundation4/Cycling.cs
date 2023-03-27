public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float minutes, float speed, string antivityName) : base(date, minutes, antivityName)
    {
        this._date = date;
        this._minutes = minutes;
        this._antivityName = antivityName;
        this._speed = speed;
    }
}