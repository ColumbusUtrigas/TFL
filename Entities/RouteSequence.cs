namespace TFL.Entities;

public class RouteSequence : IIdentifiable
{
    public string LineId;
    public string LineName;
    public string Direction;
    public bool IsOutboundOnly;
    public string Mode;
    public List<string> LineStrings;
    public List<MatchedStop> Stations;
    public List<StopPointSequence> StopPointSequences;
    public List<OrderedRoute> OrderedLineRoutes;

    public Identifier ToIdentifier() => new()
    {
        Id = LineId,
        Type = nameof(RouteSequence),
        Uri = $"/Line/{LineId}/Route/Sequence/{Direction}"
    };
}