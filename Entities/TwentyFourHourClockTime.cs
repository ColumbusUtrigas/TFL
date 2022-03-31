namespace TFL.Entities;

public class TwentyFourHourClockTime
{
    public string Hour;
    public string Minute;

    public TimeSpan ToTimeSpan() => new(int.Parse(Hour), int.Parse(Minute), 0);
}