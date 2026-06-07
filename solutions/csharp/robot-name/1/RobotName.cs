public class Robot
{
    private static readonly Random _random = new();
    private static readonly List<string> _names = [];
    private static readonly char[] _characters = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];

    public string Name { get; private set; } = GetNewName();

    public void Reset() => Name = GetNewName();

    private static string GetNewName()
    {
        var letters = _random.GetString(_characters, 2);
        var number = _random.Next(100, 1000);
        var name = $"{letters}{number}";

        if (!_names.Contains(name))
        {
            _names.Add(name);
            return name;
        }
        else
        {
            return GetNewName();
        }
    }
}