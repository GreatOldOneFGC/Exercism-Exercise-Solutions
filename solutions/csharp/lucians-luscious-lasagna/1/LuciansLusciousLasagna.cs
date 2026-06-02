class Lasagna
{
    const int MINUTES_PER_LAYER = 2;

    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int actual_minutes) => ExpectedMinutesInOven() - actual_minutes;

    public int PreparationTimeInMinutes(int number_of_layers) => number_of_layers * MINUTES_PER_LAYER;

    public int ElapsedTimeInMinutes(int number_of_layers, int actual_minutes) => PreparationTimeInMinutes(number_of_layers) + actual_minutes;
}
