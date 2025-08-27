public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
{
    switch (report)
    {
        case int a:
            return $"There are {a} supporters at the match.";

        case string b:
            return b;

        case Injury j:
            return j.GetDescription().Replace("Player", "Oh no! Player") + " Medics are on the field.";

        case Incident i:
            return i.GetDescription();

        case Manager m:
            return m.Club is null ? m.Name : $"{m.Name} ({m.Club})";

        default:
            return "";
    }
}

}
