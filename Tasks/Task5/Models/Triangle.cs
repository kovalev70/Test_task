using Task5.Abstractions;

namespace Task5.Models;

public class Triangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double perimeter = CalculatePerimeter() / 2;
        return Math.Sqrt
            (perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }

    public override string GetInfo()
    {
        return $"Figure Type: {GetType().Name}, " +
            $"SideA: {SideA}, " +
            $"SideB: {SideB}, " +
            $"SideC: {SideC}, " +
            $"Area: {CalculateArea()}, " +
            $"Perimeter: {CalculatePerimeter()}";
    }
}
