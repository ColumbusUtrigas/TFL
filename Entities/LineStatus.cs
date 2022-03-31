using System.Globalization;

namespace TFL.Entities;

public class LineStatus : IIdentifiable
{
    public string Id;
    public string LineId;
    public int? StatusSeverity;
    public string StatusSeverityDescription;
    public string Reason;
    public DateTime Created;
    public DateTime? Modified;

    public Identifier ToIdentifier() => new()
    {
        Id = Id.ToString(CultureInfo.InvariantCulture),
        Name = $"{StatusSeverity} - {StatusSeverityDescription}",
        Type = nameof(LineStatus),
        Uri = $"/Line/{Id}/Status"
    };
}