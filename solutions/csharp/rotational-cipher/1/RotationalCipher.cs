public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var result = new System.Text.StringBuilder();
        foreach (char ch in text) 
        {
            if (ch >= 'A' && ch <= 'Z')
            {
                char shiftedChar = (char)('A' + (ch - 'A' + shiftKey) % 26);
                result.Append(shiftedChar);
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                char shiftedChar = (char)('a' + (ch - 'a' + shiftKey) % 26);
                result.Append(shiftedChar);
            }
            else
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }
}