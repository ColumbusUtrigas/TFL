namespace TFL.Entities;

public class Line : IIdentifiable
{
    public string Id;
    public string Name;
    public string ModeName;
    public List<Disruption> Disruptions;
    public DateTime Created;
    public DateTime? Modified;
    public List<LineStatus> LineStatus;
    public List<MatchedRoute> RouteSections;
    public List<LineServiceTypeInfo> ServiceTypes;
    public Crowding Crowding;

    public Identifier ToIdentifier() => new()
    {
        Id = Id,
        Name = Name,
        Type = nameof(Line),
        Uri = $"/Line/{Id}",
        Crowding = Crowding
    };
}