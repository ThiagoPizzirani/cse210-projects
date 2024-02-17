using System;
using  System.Collections.Generic;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _order = new List<Order>();

        Address address = new Address("1325 Main Avenue", "Atlanta", "Georgia", "USA");
        Customer customer = new Customer("Robert Stuart", address);

        Order order1 = new Order();

        Product product1 = new Product("Winter Glove - Gray - XL",125327,18.99,2);
        Product product2 = new Product("Men's Hat - Black - Adult",378449,12.10,3);
        Product product3 = new Product("Kid's T-Shirt - White - Small",567832,7.99,4);

       _order.Add(order1);

       order1.AddProduct(product1);
       order1.AddProduct(product2);
       order1.AddProduct(product3);

       Order order2 = new Order();

       Product product4 = new Product("Leather Brown Purse",322551,31.22,4);
       Product product5 = new Product("Silver Dress Shoes",700189,15.50,6);
       Product product6 = new Product("Washed Blue Jeans Jacket",288597,49.00,5);

       _order.Add(order2);

       order2.AddProduct(product4);
       order2.AddProduct(product5);
       order2.AddProduct(product6);

       // Provide Order information for each order with a set of products + Packing and Shipping Labels 
       foreach (Order order in _order)
       {
        double totalCost = 0;
        Console.WriteLine("---------Packing Label ---------");

        List<Product> products = order.GetProduct();

        foreach (Product prod in products)
            {
                totalCost += prod.TotalUnitCost();
                prod.Display();

            }
            order.Shipping(address.SendCountry());
            Console.WriteLine("\n---------Shipping Label---------");
            Console.WriteLine($"Customer: {customer.GetCustomerName()}");
            address.GetAddress();

            string printOrderCost = order.TotalOrderPrice(totalCost).ToString("0.##");
            Console.WriteLine($"The total Order Cost: {printOrderCost}");
            Console.WriteLine($"\n__________________________________________\n");
       }


    }
}