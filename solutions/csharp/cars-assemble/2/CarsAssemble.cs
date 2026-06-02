static class AssemblyLine
{
    const int CARS_PER_HOUR = 221;
    const int MINUTES_PER_HOUR = 60;
    public static double SuccessRate(int speed) => speed switch
    {
        >= 10 => 0.77,
        9 => 0.8,
        >= 5 => 0.9,
        >= 1 => 1.0,
        _ => 0.0
    };

    public static double ProductionRatePerHour(int speed) => CARS_PER_HOUR * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / MINUTES_PER_HOUR;
}
