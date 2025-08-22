public static class Pangram
{
public static bool IsPangram(string input)
{
    string inputUpper = input.ToUpper();
    
    for (char letter = 'A'; letter <= 'Z'; letter++)
    {
        if (!inputUpper.Contains(letter))
            return false;
    }
    
    return true;
}
}
