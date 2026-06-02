static class AssemblyLine
{
    const int CARS_PER_HOUR = 221;
    const int MINUTES_PER_HOUR = 60;
    public static double SuccessRate(int speed)
    {
        if (speed >= 10)
        {
            return 0.77;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed >= 5)
        {
            return 0.9;
        }
        else if (speed >= 1)
        {
            return 1.0;
        }
        else
        {
            return 0.0;
        }
    }

    public static double ProductionRatePerHour(int speed) => CARS_PER_HOUR * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / MINUTES_PER_HOUR;
}
