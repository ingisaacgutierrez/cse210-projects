using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
    :base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string getSpeaker()
    {
        return _speaker;
    }

    public int getCapacity()
    {
        return _capacity;   
    }
     public override string FullDetails()
    {
        return $"{StandardDetails()} \nSpeaker: {_speaker} \nCapacity: {_capacity} people";
    }
}