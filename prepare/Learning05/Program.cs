using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square quad = new Square(22.50, "Blue");
        string color = quad.GetColor();
        double area = quad.GetArea();

        Console.WriteLine($"Square color is {color} and area of {area}");

        Rectangle rect = new Rectangle(10, 15, "Red");
        string colorRect = rect.GetColor();
        double areaRect = rect.GetArea();

        Console.WriteLine($"\nRectangle color is {colorRect} and area of {areaRect}");

        Circle circ = new Circle(13.15, "Green");
        string colorCirc = circ.GetColor();
        double areaCirc = circ.GetArea();

        Console.WriteLine($"\nCircle color is {colorCirc} and area of {areaCirc}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(quad);
        shapes.Add(rect);
        shapes.Add(circ);

        foreach (Shape shape in shapes)
        {
            string colorShape = shape.GetColor();
            double areaShape = shape.GetArea();

            Console.WriteLine($"\nFrom the list, the shape color is {colorShape} and the area is {areaShape}");
        }


    }
}