public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min)- Distance {GetDistance().ToString("F1")} miles, Speed {GetSpeed().ToString("F1")} mph, Pace: {GetPace().ToString("F1")} min per mile";
    }
}