public static class ScrabbleScore
{
    private static readonly Dictionary<string, int> _scores = new()
    {
        ["aeioulnrst"] = 1,
        ["dg"] = 2,
        ["bcmp"] = 3,
        ["fhvwy"] = 4,
        ["k"] = 5,
        ["jx"] = 8,
        ["qz"] = 10
    };

    public static int Score(string input) => input.Sum(c => _scores.First(kvp => kvp.Key.Contains(char.ToLower(c))).Value);
}