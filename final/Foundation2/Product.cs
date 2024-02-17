public class Product 
{
    private string _prodName;
    private int _prodId;
    private double _prodPrice;
    private int _quantity;

    public Product(string name, int id, double price, int quant)
    {
        _prodName = name;
        _prodId = id;
        _prodPrice = price;
        _quantity = quant;
    }

    public double TotalUnitCost()
    {
        return _prodPrice * _quantity;
    }
     public void Display()
    {
        Console.WriteLine($"Product Name: {_prodName} | Id: {_prodId}");
    }
}