public static class Pangram
{
    private const string LETTERS = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input) => LETTERS.All(input.ToLower().Contains);
}
