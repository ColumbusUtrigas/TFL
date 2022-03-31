namespace TFL.Entities;

public class KnownJourney
{
    public string Hour;
    public string Minute;
    public int IntervalId;

    public TimeSpan ToTimeSpan() => new(int.Parse(Hour), int.Parse(Minute), 0);
}