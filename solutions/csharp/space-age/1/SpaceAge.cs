public class SpaceAge
{
    private const int EARTH_YEAR_IN_SECONDS = 31_557_600;
    private const double MERCURY_RELATIVE_TO_EARTH = 0.2408467;
    private const double VENUS_RELATIVE_TO_EARTH = 0.61519726;
    private const double MARS_RELATIVE_TO_EARTH = 1.8808158;
    private const double JUPITER_RELATIVE_TO_EARTH = 11.862615;
    private const double SATURN_RELATIVE_TO_EARTH = 29.447498;
    private const double URANUS_RELATIVE_TO_EARTH = 84.016846;
    private const double NEPTUNE_RELATIVE_TO_EARTH = 164.79132;

    private readonly int _age;
    public SpaceAge(int seconds) => _age = seconds;

    public double OnEarth() => (double)_age / EARTH_YEAR_IN_SECONDS;

    public double OnMercury() => _age / (EARTH_YEAR_IN_SECONDS * MERCURY_RELATIVE_TO_EARTH);

    public double OnVenus() => _age / (EARTH_YEAR_IN_SECONDS * VENUS_RELATIVE_TO_EARTH);

    public double OnMars() => _age / (EARTH_YEAR_IN_SECONDS * MARS_RELATIVE_TO_EARTH);

    public double OnJupiter() => _age / (EARTH_YEAR_IN_SECONDS * JUPITER_RELATIVE_TO_EARTH);

    public double OnSaturn() => _age / (EARTH_YEAR_IN_SECONDS * SATURN_RELATIVE_TO_EARTH);

    public double OnUranus() => _age / (EARTH_YEAR_IN_SECONDS * URANUS_RELATIVE_TO_EARTH);

    public double OnNeptune() => _age / (EARTH_YEAR_IN_SECONDS * NEPTUNE_RELATIVE_TO_EARTH);
}