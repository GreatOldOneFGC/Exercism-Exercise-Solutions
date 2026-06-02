public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        var set = TriangleSet(side1, side2, side3);
        return IsATriangle(side1, side2, side3) && set.Count == 3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        var set = TriangleSet(side1, side2, side3);
        return IsATriangle(side1, side2, side3) && set.Count < 3;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        var set = TriangleSet(side1, side2, side3);
        return IsATriangle(side1, side2, side3) && set.Count == 1;
    }

    private static HashSet<double> TriangleSet(double side1, double side2, double side3) => [side1, side2, side3];
    private static bool IsATriangle(double side1, double side2, double side3)
    {
        double[] sides = [side1, side2, side3];
        return sides.Sum() > 2 * sides.Max();
    }
}