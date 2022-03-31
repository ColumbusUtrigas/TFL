using System.Globalization;

namespace TFL.Entities;

public class Mode : IIdentifiable
{
    public bool IsTflService;
    public bool IsFarePaying;
    public bool IsScheduledService;
    public string ModeName;

    public Identifier ToIdentifier() => new()
    {
        Id = ModeName.ToString(CultureInfo.InvariantCulture),
        Name = ModeName,
        Type = nameof(Mode)
    };
}