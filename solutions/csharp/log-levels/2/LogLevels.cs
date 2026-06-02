static class LogLine
{
    public static string Message(string logLine)
    {
        var index = logLine.IndexOf(':') + 1;
        return logLine[index..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        var start_index = logLine.IndexOf('[') + 1;
        var end_index = logLine.IndexOf(']');
        return logLine[start_index..end_index].ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
