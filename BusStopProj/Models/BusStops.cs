namespace BusStopProj.Models;
/// <summary>
/// Durakların yapılandırmasını yapıyoruz.
/// </summary>
public class BusStops
{
    public int ServerId { get; set; }

    public int CustomerId { get; set; }
    
    public Guid StopId { get; set; }

    public int VehicleRoutePointId { get; set; }

    public int BusRouteId { get; set; }

    /// <summary>
    /// Sıra no
    /// </summary>
    public int OrderNo { get; set; }

    /// <summary>
    /// Varış Süresi
    /// </summary>
    public TimeSpan ArrivalTime { get; set; }

    /// <summary>
    /// Tölerans
    /// </summary>
    public int Tolerance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public BusStopType BusStopTypeId { get; set; }
}