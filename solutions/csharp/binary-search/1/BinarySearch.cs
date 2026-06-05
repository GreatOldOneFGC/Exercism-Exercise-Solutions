public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Array.Sort(input);

        var left = 0;
        var right = input.Length - 1;

        while (left <= right)
        {
            var index = left + ((right - left) / 2);

            if (input[index] < value)
            {
                left = index + 1;
            }

            else if (input[index] > value)
            {
                right = index - 1;
            }

            else if (input[index] == value)
            {
                return index;
            }
        }

        return -1;
    }
}