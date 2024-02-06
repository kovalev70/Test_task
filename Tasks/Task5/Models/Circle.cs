using Task5.Abstractions;

namespace Task5.Models;

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string GetInfo()
    {
        return $"Figure Type: {GetType().Name}, " +
            $"Radius: {Radius}, " +
            $"Area: {CalculateArea()}, " +
            $"Perimeter: {CalculatePerimeter()}";
    }
}
