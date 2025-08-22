public static class LogAnalysis
{
    public static string SubstringAfter(this string logLine, string delimiter)
    {
        int index = logLine.IndexOf(delimiter);
        return logLine.Substring(index + delimiter.Length);
    }

    public static string SubstringBetween(this string logLine, string start, string end)
    {
        int startIndex = logLine.IndexOf(start) + start.Length;
        int endIndex = logLine.IndexOf(end, startIndex);
        return logLine.Substring(startIndex, endIndex - startIndex);
    }

    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ").Trim();
    }

    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}
