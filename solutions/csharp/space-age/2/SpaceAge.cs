public class SpaceAge(int seconds)
{
    private const double EARTH_YEAR_IN_SECONDS = 31_557_600.0;
    private const double MERCURY_YEAR_RELATIVE_TO_EARTH = 0.2408467;
    private const double VENUS_YEAR_RELATIVE_TO_EARTH = 0.61519726;
    private const double MARS_YEAR_RELATIVE_TO_EARTH = 1.8808158;
    private const double JUPITER_YEAR_RELATIVE_TO_EARTH = 11.862615;
    private const double SATURN_YEAR_RELATIVE_TO_EARTH = 29.447498;
    private const double URANUS_YEAR_RELATIVE_TO_EARTH = 84.016846;
    private const double NEPTUNE_YEAR_RELATIVE_TO_EARTH = 164.79132;

    private double AgeRelativeToEarth(double relativeYears) =>  seconds / (EARTH_YEAR_IN_SECONDS * relativeYears);

    public double OnEarth() => seconds / EARTH_YEAR_IN_SECONDS;

    public double OnMercury() => AgeRelativeToEarth(MERCURY_YEAR_RELATIVE_TO_EARTH);

    public double OnVenus() => AgeRelativeToEarth(VENUS_YEAR_RELATIVE_TO_EARTH);

    public double OnMars() => AgeRelativeToEarth(MARS_YEAR_RELATIVE_TO_EARTH);

    public double OnJupiter() => AgeRelativeToEarth(JUPITER_YEAR_RELATIVE_TO_EARTH);

    public double OnSaturn() => AgeRelativeToEarth(SATURN_YEAR_RELATIVE_TO_EARTH);

    public double OnUranus() => AgeRelativeToEarth(URANUS_YEAR_RELATIVE_TO_EARTH);

    public double OnNeptune() => AgeRelativeToEarth(NEPTUNE_YEAR_RELATIVE_TO_EARTH);
}