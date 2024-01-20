using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.GetFractionString();
        f.GetDecimalValue();
        
        f.SetTop(5);
        f.GetFractionString();
        f.GetDecimalValue();

        f.SetTop(3);
        f.SetBottom(4);
        f.GetFractionString();
        f.GetDecimalValue();

        f.SetTop(1);
        f.SetBottom(3);
        f.GetFractionString();
        f.GetDecimalValue();

    }
}