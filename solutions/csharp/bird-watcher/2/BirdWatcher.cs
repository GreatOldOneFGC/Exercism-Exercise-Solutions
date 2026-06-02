class BirdCount(int[] birdsPerDay)
{
    private static readonly int[] _birdsLastWeek = [0, 2, 5, 3, 7, 8, 4];

    public static int[] LastWeek() => _birdsLastWeek;

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => birdsPerDay.Count(x => x >= 5);
}
