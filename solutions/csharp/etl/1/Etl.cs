public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newdict = new Dictionary<string, int>();
        foreach (KeyValuePair<int, string[]> entry in old){
            int points = entry.Key;
            string[] letters = entry.Value;
            foreach (string letter in letters) {
                newdict[letter.ToLower()] = points;
            } 
        }
        return newdict;
    }
}