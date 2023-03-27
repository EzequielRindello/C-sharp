public class Activity
{
    protected string _date;
    protected float _minutes;

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
}