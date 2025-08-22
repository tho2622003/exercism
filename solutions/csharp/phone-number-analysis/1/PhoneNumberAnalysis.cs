    public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
{
    bool isNewYork;
    bool isFake;
    string localNumber;
    
    if (phoneNumber.Substring(0, 3) == "212") 
        isNewYork = true;
    else 
        isNewYork = false;
        
    if (phoneNumber.Substring(4, 3) == "555") 
        isFake = true;
    else 
        isFake = false;
        
    localNumber = phoneNumber.Substring(8, 4);
    
    return (isNewYork, isFake, localNumber);
}

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
    if (phoneNumberInfo.IsFake == true) return true;
        else return false;
    }
}
