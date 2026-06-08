public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> set = [];

        foreach (char c in word.ToLower())
        {
            if (!char.IsLetter(c))
            {
                continue;
            }

            if (!set.Contains(c))
            {
                set.Add(c);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
