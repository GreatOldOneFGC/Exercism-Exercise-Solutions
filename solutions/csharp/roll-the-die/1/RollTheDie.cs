public class Player
{
    private static readonly Random _ran = new();
    public int RollDie() => _ran.Next(1, 19);

    public double GenerateSpellStrength()
    {
        double range = _ran.Next(100);
        return range + _ran.NextDouble();
    }
}
