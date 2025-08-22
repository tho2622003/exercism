public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement)) 
            return "Fine. Be that way!";

        string trimmed = statement.Trim();
        
        bool hasLetters = trimmed.ToLower() != trimmed.ToUpper();
        bool isYelling = trimmed == trimmed.ToUpper() && hasLetters;
        bool isQuestion = trimmed.EndsWith("?");
        
        if (isQuestion && isYelling) 
            return "Calm down, I know what I'm doing!";
        else if (isQuestion) 
            return "Sure.";
        else if (isYelling) 
            return "Whoa, chill out!";
        else 
            return "Whatever.";
    }
}