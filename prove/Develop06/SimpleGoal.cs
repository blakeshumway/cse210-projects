public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) :base(name, description, points)
    {
        _isComplete = false;
    }

        public SimpleGoal(string name, string description, int points, bool completion) :base(name, description, points)
    {
        _isComplete = completion;
    }
    


    public override int RecordEvent()
    {
        if (IsComplete() == false)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    //this is for files
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}