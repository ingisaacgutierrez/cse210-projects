using System;

class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
      _product.Add(product);
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    
    public double TotalPrice()
    {
        double total = 0.0;
        foreach(Product product in _product)
        {
            total += product.getPrice() * product.getQuantity();
        }
        return total;

    }

    public double TotalShipping()
    {
        
        double total = _customer.getAddress().isUSAAddress() ? 5.00 : 35.00;
        return total;

    }

    public double calculateTotalCost()
    {
        
        double shipping = TotalShipping();
        double price = TotalPrice();
        double total = price + shipping;
        return total;

    }
    public string getPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(Product product in _product)
        {
            label += $"| Name: {product.getName()} | Product_id: {product.getProductId()} | Price: ${product.getPrice()} | Quantity: {product.getQuantity()}\n";
        }
        return label;
    }
    public string getShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.getCustomerName()}\nAddres: {_customer.getAddress().getAddress()}";
    }

}