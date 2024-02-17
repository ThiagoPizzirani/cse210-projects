using  System.Collections.Generic;

public class Order
{
    private int _shipping = 0;
    private double totalPrice = 0;
    private List<Product> _products = new List<Product>();

    public int Shipping(string address)
    {
        if (address == "USA")
        {_shipping = 5;}
        else {_shipping = 35;}

        return _shipping;
    }

    public void AddProduct(Product prod)
    {
        _products.Add(prod);
    }

    public string PackingLabel(Product prodName, Product prodId)
    {
        return $"{prodName} - {prodId}";
    }

    public double TotalOrderPrice(double price)
    {
        totalPrice = price + _shipping;
        return totalPrice;
    }

    public List<Product> GetProduct()
    {
        return _products;
    }


}