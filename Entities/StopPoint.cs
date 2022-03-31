namespace TFL.Entities;

public class StopPoint : Place, IIdentifiable, IComparable<StopPoint>
{
    public string NaptanId;
    public string PlatformName;
    public string Indicator;
    public string StopLetter;
    public List<string> Modes;
    public string IcsCode;
    public string SMSCode;
    public string StopType;
    public string StationNaptan;
    public string AccessibilitySummary;
    public string HubNaptanCode;
    public List<Identifier> Lines;
    public List<LineGroup> LineGroup;
    public List<LineModeGroup> LineModeGroups;
    public string FullName;
    public string NaptanMode;
    public bool Status;
    
    public int CompareTo(StopPoint? obj) => obj == null ? -1 : string.Compare(CommonName, obj.CommonName, StringComparison.Ordinal);

    public new Identifier ToIdentifier() => new()
    {
        Id = NaptanId,
        Name = CommonName,
        Type = nameof(StopPoint),
        Uri = $"/StopPoint/{NaptanId}",
        FullName = FullName
    };
}