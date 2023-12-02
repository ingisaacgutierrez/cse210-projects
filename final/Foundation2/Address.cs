using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;        
        _country = country;
    }

    public string getStreet()
    {
        return _street;
    }

    public string getCity()
    {
        return _city;
    }
     public string getState()
    {
        return _state;
    }
     public string getCountry()
    {
        return _country;
    }
    public Boolean isUSAAddress()
    {
        Boolean isUSAAddress = false;
        if (_country.ToLower() == "usa")
        {
            isUSAAddress = true;
        }
        return isUSAAddress;
    }

    public string getAddress()
    {
        return $"{_street} / {_city} / {_state} / {_country}"; 
    }
}