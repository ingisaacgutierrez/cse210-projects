using System;

class Product
{
    private string _productName;
    private int _product_id;
    private double _price;
    private int _quantity;
    public Product( string productName, int product_id, double price, int quantity)
    {
        _productName = productName;
        _product_id = product_id;
        _price = price;
        _quantity = quantity;
    }

    public string getName()
    {
        return _productName;
    }
    public int getProductId()
    {
        return _product_id;
    }
    public double getPrice()
    {
        return _price;
    }
    public int getQuantity()
    {
        return _quantity;
    }
}