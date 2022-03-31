using TFL.Enums;

namespace TFL.Entities;

public class Disruption
{
    public string Id;
    public DisruptionCategory Category;
    public string Type;
    public string CategoryDescription;
    public string Description;
    public string Summary;
    public string AdditionalInfo;
    public DateTime Created;
    public DateTime LastUpdate;
    public List<DisruptedRoute> AffectedRoutes;
    public List<StopPoint> AffectedStops;
    public bool IsBlocking;
    public bool IsWholeLine;
    public string ClosureText;
}