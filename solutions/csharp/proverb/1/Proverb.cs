public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0)
        {
            return [];
        }

        var proverb = new string[subjects.Length];

        for (int i = 0; i + 1 < subjects.Length; i++)
        {
            proverb[i] = Line(subjects[i], subjects[i + 1]);
        }

        proverb[subjects.Length - 1] = $"And all for the want of a {subjects[0]}.";

        return proverb;
    }

    private static string Line(string first, string second) => $"For want of a {first} the {second} was lost.";
}