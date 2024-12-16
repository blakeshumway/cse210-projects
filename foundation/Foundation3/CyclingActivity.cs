public class CyclingActivity : Activity
{
    private double _distance;

    public CyclingActivity(string date, double length, double distance) :base(date, length) 
    {
        _distance = distance;
        _activityName = "Cycling";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    
    public override double GetPace()
    {
        return _length / _distance;
    }
    


}