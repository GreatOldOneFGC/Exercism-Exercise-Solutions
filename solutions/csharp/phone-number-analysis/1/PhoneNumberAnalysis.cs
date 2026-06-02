public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var numbers = phoneNumber.Split("-");
        bool isNewYork = numbers[0] == "212";
        bool isFake = numbers[1] == "555";
        string localNumber = numbers[2];
        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
