namespace TFL.Entities;

public class MatchedStop : SearchMatch, IIdentifiable, IComparable<MatchedStop>
{
    public int RouteId;
    public string ParentId;
    public string StationId;
    public string IcsId;
    public string TopMostParentId;
    public string Direction;
    public string Towards;
    public List<string> Modes;
    public string StopType;
    public string StopLetter;
    public string Zone;
    public string AccessibilitySummary;
    public bool HasDisruption;
    public List<Identifier> Lines;
    public bool Status;
    
    public Identifier ToIdentifier() => new()
    {
        Id = Id,
        Name = Name,
        Type = nameof(StopPoint),
        Uri = "/StopPoint/" + Id
    };

    public int CompareTo(MatchedStop? obj) => obj == null ? -1 : string.Compare(Name, obj.Name, StringComparison.Ordinal);
}