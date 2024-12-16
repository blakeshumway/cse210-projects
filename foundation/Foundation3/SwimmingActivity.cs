using System.IO.Pipes;

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, double length, int laps) :base(date, length) 
    {
        _laps = laps;
        _activityName = "Swimming";
    }


    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length ) * 60;
    }
    
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return Math.Round(pace, 2);
    }
}

