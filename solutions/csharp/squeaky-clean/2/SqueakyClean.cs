using System.Text;

public static class Identifier
{
    private static bool IsGreekLetter(char c) => char.IsBetween(c, 'α', 'ω');
    public static string Clean(string identifier)
    {
        var builder = new StringBuilder();
        var isAfterDash = false;

        foreach (char c in identifier)
        {
            builder.Append(c switch
            {
                _ when IsGreekLetter(c) => default,
                _ when isAfterDash => char.ToUpper(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            isAfterDash = c == '-';
        }

        return builder.ToString();
    }
}
