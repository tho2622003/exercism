static class LogLine
{
    public static string Message(string logLine)
    {
        int colon = logLine.IndexOf(":");
        return logLine.Substring(colon + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int index = logLine.IndexOf(":") - 2;
        string error = logLine.Substring(1, index);
        return error.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
