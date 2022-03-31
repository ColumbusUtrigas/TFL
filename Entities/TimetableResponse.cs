using TFL.Entities.Timetables;

namespace TFL.Entities;

public class TimetableResponse
{
    public string LineId;
    public string LineName;
    public string Direction;
    public string PdfUrl;
    public List<MatchedStop> Stations;
    public List<MatchedStop> Stops;
    public Timetable Timetable;
    public Disambiguation Disambiguation;
    public string StatusErrorMessage;
}