using System.ComponentModel.DataAnnotations;

public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)- Distance {GetDistance().ToString("F1")} miles, Speed {GetSpeed().ToString("F1")} mph, Pace: {GetPace().ToString("F1")} min per mile";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

}