public class Address
{
    private string _street;
    private string _cityAndState;
    private string _country;
    private bool _inUSA;


    public Address(string street, string cityAndState, string country, bool inUSA)
    {
        _street = street;
        _cityAndState = cityAndState;
        _country = country;
        _inUSA = inUSA;
    }


    public bool IsInUSA()
    {
        return _inUSA;
    }


    public string GetAddress()
    {
        string address = _street + ", " + _cityAndState + ", " + _country;
        return address;
    }


}