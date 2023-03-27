public class Activity
{
    protected string _date;
    protected float _time;

    public Activity(string date, float time)
    {
        this._date = date;
        this._time = time;
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

    public virtual string Summary()
    {
        return $"";
    }
}