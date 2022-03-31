using System.Web;

namespace TFL.Entities;

public class Place : Point, IIdentifiable
{
    public string Id;
    public string Url;
    public string CommonName;
    public double Distance;
    public string PlaceType;
    public List<AdditionalProperties> AdditionalProperties;
    public List<Place> Children;
    public List<string> ChildrenUrls;

    public Identifier ToIdentifier() => new()
    {
        Id = Id,
        Name = CommonName,
        Type = nameof(Place),
        Uri = $@"/Place/{HttpUtility.UrlEncode(Id)}"
    };
}