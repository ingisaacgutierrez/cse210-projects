using System;

class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    public string getCustomerName()
    {
        return _customerName;
    }
    public Address getAddress()
    {
        return _address;
    }
   

}