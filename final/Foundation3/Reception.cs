using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string title, string description, DateTime dateTime, Address address)
        :base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public override string FullDetails()
    {
        return $"{StandardDetails()} \nRSVP Email: {_rsvpEmail}";
    }
}