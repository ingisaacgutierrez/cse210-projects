using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("\n------------------------------------First Order----------------------------------------");
       Product _proOne = new Product("cereal", 235,5.23,2);
       Product _proTwo = new Product("sugar", 22,8.50,4);
       Product _proThree = new Product("rice", 556,5.60,1);

       Address addressOne = new Address("123 Main St","Interlachen", "FL", "USA");

       Customer customerOne = new Customer("Isaac", addressOne);

       Order orderOne = new Order(customerOne);
       orderOne.AddProduct(_proOne);
       orderOne.AddProduct(_proTwo);
       orderOne.AddProduct(_proThree);
       
       Console.WriteLine($"\n{orderOne.getPackingLabel()}");
       Console.WriteLine(orderOne.getShippingLabel());
       Console.WriteLine($"\nPrice: ${orderOne.TotalPrice()}");
       Console.WriteLine($"Shipping: ${orderOne.TotalShipping()}");
       Console.WriteLine($"Total: ${orderOne.calculateTotalCost()}\n");

       
       Console.WriteLine("------------------------------------Second Order----------------------------------------");   
       Product _prodOne = new Product("milk", 112,1.63,5);
       Product _prodTwo = new Product("chocolate", 530,1.00,10);
       Product _prodThree = new Product("juice", 003,4.25,2);

       Address addressTwo = new Address("Urbanor 350 NO","Guayaquil", "Guayas", "ECU");

       Customer customerTwo = new Customer("Efrain", addressTwo);

       Order orderTwo = new Order(customerTwo);
       orderTwo.AddProduct(_prodOne);
       orderTwo.AddProduct(_prodTwo);
       orderTwo.AddProduct(_prodThree);
       
       Console.WriteLine($"\n{orderTwo.getPackingLabel()}");
       Console.WriteLine(orderTwo.getShippingLabel());
       Console.WriteLine($"\nPrice: ${orderTwo.TotalPrice()}");
       Console.WriteLine($"Shipping: ${orderTwo.TotalShipping()}");
       Console.WriteLine($"Total: ${orderTwo.calculateTotalCost()}\n");
    }
}