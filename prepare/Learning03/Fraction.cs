
public class Fraction
{
    private int _bottom;
    private int _top;


    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int number)
    {
        _bottom = 1;
        _top = number;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }


    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        
        // this string needs to return something instad of set it
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
    

}