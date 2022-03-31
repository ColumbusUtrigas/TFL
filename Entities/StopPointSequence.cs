using TFL.Enums;

namespace TFL.Entities;

public class StopPointSequence : IIdentifiable
{
    public string LineId;
    public string LineName;
    public string Direction;
    public int BranchId;
    public List<int> NextBranchIds;
    public List<int> PrevBranchIds;
    public List<MatchedStop> StopPoint;
    public ServiceType ServiceType;
    
    public Identifier ToIdentifier() => new()
    {
        Id = LineId,
        Type = nameof(StopPointSequence),
        Uri = $"/Line/{LineId}/Route/Sequence/{Direction}"
    };
}