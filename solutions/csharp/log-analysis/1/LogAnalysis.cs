using Xunit.v3;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string prefix, string suffix)
    {
        var startIndex = str.IndexOf(prefix) + prefix.Length;
        var endIndex = str.IndexOf(suffix);
        return str[startIndex..endIndex];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}