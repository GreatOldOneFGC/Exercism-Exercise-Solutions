public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var set = new HashSet<int>();
        foreach (int multiple in multiples)
        {
            if (multiple <= 0)
                continue;

            for (int i = multiple; i < max; i += multiple)
            {
                set.Add(i);
            }
        }
        return set.Sum();
    }
}