public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float time, float speed) : base(date, time)
    {
        this._date = date;
        this._time = time;
        this._speed = speed;
    }
}