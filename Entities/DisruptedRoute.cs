using System.Globalization;

namespace TFL.Entities;

public class DisruptedRoute : IIdentifiable
{
    public string Id;
    public string LineId;
    public string RouteCode;
    public string Name;
    public string LineString;
    public string Direction;
    public string OriginationName;
    public string DestinationName;
    public RouteSectionNaptanEntrySequence Via;
    public bool? IsEntireRouteSection;
    public DateTime? ValidTo;
    public DateTime? ValidFrom;
    public List<RouteSectionNaptanEntrySequence> RouteSectionNaptanEntrySequence;

    public Identifier ToIdentifier() => new()
    {
        Id = Id.ToString(CultureInfo.InvariantCulture),
        Name = Name,
        Type = nameof(RouteSection)
    };
}