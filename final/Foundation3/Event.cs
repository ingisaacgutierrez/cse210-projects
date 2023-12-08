using System;

abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }
   
    public virtual string StandardDetails()
    {
       
       return $"\nTitle: {_title} \nDescription: {_description} \nDate & Hour: {_dateTime.ToString("MM/dd/yyyy - HH:mm")} \nAddress:{_address.getAddress()}";
    }
    public abstract string FullDetails();
 
    
    public string ShortDescription()
    {
        return $"\nTitle: {_title} \nDate & Hour: {_dateTime.ToString("MM/dd/yyyy")}";   
    }

}