using System.Globalization;

namespace TFL.Entities;

public class MatchedRoute : IIdentifiable
{
    public string Id;
    public string LineId;
    public string RouteCode;
    public string Name;
    public string Direction;
    public string OriginationName;
    public string DestinationName;
    public string Originator;
    public string Destination;
    public string ServiceType;
    public DateTime? ValidTo;
    public DateTime? ValidFrom;
    
    public Identifier ToIdentifier() => new()
    {
        Id = Id.ToString(CultureInfo.InvariantCulture),
        Name = Name,
        Type = nameof(MatchedRoute),
        Uri = $"/MatchedRoute/{Id}"
    };
}