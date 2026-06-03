public static class ReverseString
{
    public static string Reverse(string input)
    {
        var reversedString = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i];
        }

        return reversedString;
    }
}