
public class Customer
{

    private string _name; 

    public Customer(string name, Address adress)
    {
        _name = name;
    }

    public string GetCustomerName()
    {
        return _name;
    }

}