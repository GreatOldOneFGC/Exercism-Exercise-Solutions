using System.Globalization;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var builder = new StringBuilder(identifier);

        for (int i = identifier.Length - 1; i >= 0; i--)
        {
            var c = identifier[i];

            if (char.IsWhiteSpace(c))
            {
                builder.Remove(i, 1).Insert(i, '_');
            }

            else if (char.IsControl(c))
            {
                builder.Remove(i, 1).Insert(i, "CTRL");
            }

            else if (c == '-' && char.IsLetter(identifier[i + 1]))
            {
                char upper = char.ToUpper(identifier[i + 1]);
                builder.Remove(i, 2).Insert(i, upper);
            }

            else if (!char.IsLetter(c))
            {
                builder.Remove(i, 1);
            }

            else if (char.IsBetween(c, 'α', 'ω'))
            {
                builder.Remove(i, 1);
            }
        }

        return builder.ToString();
    }
}
