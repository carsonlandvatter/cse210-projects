public class CyclingActivity : Activity
{
    //Inlcudes speed but needs distance and pace
    private double _speed;
    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)- Distance {GetDistance().ToString("F1")} miles, Speed {GetSpeed().ToString("F1")} mph, Pace: {GetPace().ToString("F1")} min per mile";
    }

    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}