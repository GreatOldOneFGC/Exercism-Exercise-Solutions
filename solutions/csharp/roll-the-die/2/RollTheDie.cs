public class Player
{
    private static readonly Random _ran = new();
    public int RollDie() => _ran.Next(1, 19);

    public double GenerateSpellStrength() => _ran.NextDouble() * 100;
}
