public abstract class Activity
{
    protected string _date;
    protected double _length;

    protected string _activityName;


    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    





}