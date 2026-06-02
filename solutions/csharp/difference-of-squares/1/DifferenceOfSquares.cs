public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var result = 0;
        for (var i = 0; i < max + 1; i++)
            {result += i;}
        return result * result;
    }

    public static int CalculateSumOfSquares(int max) => max * (max + 1) * ((2 * max) + 1) / 6;

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}