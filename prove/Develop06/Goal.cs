using System.Security.Cryptography.X509Certificates;

public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    //might be void
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkBox = "[ ]";
        if (IsComplete() == true)
        {
            checkBox = "[x]";
        }

        return $"{checkBox} {_shortName} ({_description}) ";
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract string GetStringRepresentation();



}