using System;

class Program
{
    static void Main(string[] args)
    {
        //make a list for any class that inherits from the shape class
        List<Shape> shapes = new List<Shape>();

        //make a square
        Square square = new Square("Green", 4);
        shapes.Add(square);

        //make a rectangle
        Rectangle rectangle = new Rectangle("Yellow", 8, 4);
        shapes.Add(rectangle);

        //make a circle
        Circle circle = new Circle("red", 7);
        shapes.Add(circle);


        //go through each shape and call their methods
        foreach (Shape s in shapes)
        {
            //all shapes have a GetColor() method
            string color = s.GetColor();

            //all shapes have a GetArea() method, although it is different for each
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
            Console.WriteLine();
        }
    }
}