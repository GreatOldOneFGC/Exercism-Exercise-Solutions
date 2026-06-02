public static class SquareRoot
{
    public static int Root(int number)
    {
        var i = 1;
        var result = 0;
        while (number > 0)
        {
            number -= i;
            result++;
            i += 2;
        }
        return result;
    }
}
