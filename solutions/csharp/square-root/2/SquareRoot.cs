public static class SquareRoot
{
    public static int Root(int number)
    {
        var result = 1;
        while (result * result < number) result++;
        return result;
    }
}
