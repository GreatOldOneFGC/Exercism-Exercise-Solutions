public static class Darts
{
    public static int Score(double x, double y)
    {
        var result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        return result switch
        {
            > 10.0 => 0,
            > 5.0 => 1,
            > 1.0 => 5,
            _ => 10
        };
    }
}
