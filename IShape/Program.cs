using IShape;
using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(6,5,7,8);
        double triangleArea = triangle.CalculateArea();
        double triangleP = triangle.CalculatePerimeter();
        Console.WriteLine($"Triangle Area: {triangleArea}");
        Console.WriteLine($"Triangle Perimeter: {triangleP}");


        Rectangle rectangle = new Rectangle(6, 9);
        double rectangleArea = rectangle.CalculateArea();
        double rectanglePerimeter = rectangle.CalculatePerimeter();
        Console.WriteLine($"Rectangle Area: {rectangleArea}");
        Console.WriteLine($"Rectangle Perimeter: {rectanglePerimeter}");


        Prism prism = new Prism(5, 3, 8);
        double prismArea = prism.CalculateArea();
        Console.WriteLine($"Prism Area: {prismArea}");


        Trapezium trapezium = new Trapezium(5, 10, 6, 8, 8);
        double trapeziumArea = trapezium.CalculateArea();
        double trapeziumPerimeter = trapezium.CalculatePerimeter();
        Console.WriteLine($"Trapezium Area: {trapeziumArea}");
        Console.WriteLine($"Trapezium Perimeter: {trapeziumPerimeter}");



    }
}

