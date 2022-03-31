using TFL.Enums;

namespace TFL.Entities;

public class Period
{
    public TimetablePeriodType Type;
    public TwentyFourHourClockTime FromTime;
    public TwentyFourHourClockTime ToTime;
    public ServiceFrequency Frequency;
}