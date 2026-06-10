public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newDictionary = [];

        foreach (var pair in old)
        {
            foreach (var letter in pair.Value)
            {
                newDictionary.Add(letter.ToLower(), pair.Key);
            }
        }

        return newDictionary;
    }
}