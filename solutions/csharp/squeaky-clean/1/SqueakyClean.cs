public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new System.Text.StringBuilder();
        for (int i = 0; i < identifier.Length; i++)
        {
            char a = identifier[i];
            if (a == ' ')
                result.Append('_');
            else if (char.IsControl(a))
                result.Append("CTRL");
            else if (a == '-' && i + 1 < identifier.Length && char.IsLetter(identifier[i + 1]))
            {
                result.Append(char.ToUpper(identifier[i + 1]));
                i++;
            }
            else if (char.IsLetter(a))
            {
                if (a >= 'α' && a <= 'ω')
                    continue;
                
                result.Append(a);
            }
        }
        return result.ToString();
    }
}