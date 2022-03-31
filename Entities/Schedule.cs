namespace TFL.Entities;

public class Schedule
{
    public string Name;
    public List<KnownJourney> KnownJourneys;
    public KnownJourney FirstJourney;
    public KnownJourney LastJourney;
    public List<Period> Periods;
}