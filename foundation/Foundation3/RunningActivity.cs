public class RunningActivity : Activity
{
    private double _speed;

    public RunningActivity(string date, double length, double speed) :base(date, length) 
    {
        _speed = speed;
        _activityName = "Running";
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    
    public override double GetPace()
    {
        return 60 / _speed;
    }
}