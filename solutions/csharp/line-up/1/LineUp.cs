public static class LineUp
{
    public static string Format(string name, int number)
    {
        var digits = number.ToString();
        string ordinal;
        if (digits.EndsWith("11") || digits.EndsWith("12") || digits.EndsWith("13"))
        {
            ordinal = "th";
        }
        else if (digits.EndsWith("1"))
        {
            ordinal = "st";
        }
        else if (digits.EndsWith("2"))
        {
            ordinal = "nd";
        }
        else if (digits.EndsWith("3"))
        {
            ordinal = "rd";
        }
        else
        {
            ordinal = "th";
        }
        return $"{name}, you are the {number}{ordinal} customer we serve today. Thank you!";
    }
}
