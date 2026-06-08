public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> uniqueChars = [];

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                uniqueChars.Add(char.ToLower(c));
            }
        }

        return uniqueChars.Count == 26;
    }
}
