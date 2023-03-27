public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float minutes, float speed) : base(date, minutes)
    {
        this._date = date;
        this._minutes = minutes;
        this._speed = speed;
    }
}