public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = word.ToLower().Where(char.IsLetter).ToList();
        return letters.Distinct().Count() == letters.Count;
    }
}
