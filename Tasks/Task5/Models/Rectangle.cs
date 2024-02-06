using Task5.Abstractions;

namespace Task5.Models;

public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public override string GetInfo()
    {
        return $"Figure Type: {GetType().Name}, " +
            $"Width: {Width}, " +
            $"Height: {Height}, " +
            $"Area: {CalculateArea()}, " +
            $"Perimeter: {CalculatePerimeter()}";
    }
}
