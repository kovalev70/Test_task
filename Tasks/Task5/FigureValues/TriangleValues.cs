namespace Task5.FigureValues;

public static class TriangleValues
{
    public static List<(double sideA, double sideB, double sideC)> GetTriangleValues()
    {
        return new List<(double sideA, double sideB, double sideC)>
        {
            (2, 2, 3),
            (2, 3, 4),
            (3, 4, 5),
            (4, 5, 6),
        };
    }
}
