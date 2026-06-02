class BirdCount
{
    private int[] birdsPerDay;
    private static readonly int[] _birdsLastWeek = {0, 2, 5, 3, 7, 8, 4};

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => _birdsLastWeek;

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int birds = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            birds += birdsPerDay[i];
        }

        return birds;
    }

    public int BusyDays()
    {
        int days = 0;

        foreach (var birds in birdsPerDay)
        {
            if (birds >= 5) days++;
        }

        return days;
    }
}
