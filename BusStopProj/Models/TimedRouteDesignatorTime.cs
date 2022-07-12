namespace BusStopProj.Models;

/// <summary>
/// Zamanlı güzergah belirleyici zamanları
/// </summary>
public class TimedRouteDesignatorTime
{
    
    public Guid TimedRouteDesignatorTimeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }
    
}