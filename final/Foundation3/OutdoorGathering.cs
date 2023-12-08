using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
    :base(title, description, dateTime, address)
    {
        _weatherForecast = weatherForecast;
    }
    public string getWeatherForecast()
    {
        return _weatherForecast;
    }
     public override string FullDetails()
    {
        return $"{StandardDetails()} \nWeather Forecast: {_weatherForecast}";
    }
}