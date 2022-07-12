namespace BusStopProj.Models;

public struct LastStatus
{
    public int ServerId { get; set; }

    public int CustomerId { get; set; }
    
    public int VehicleId { get; set; }

    /// <summary>
    /// Otobüs güzergahı bilgisidir. 
    /// </summary>
    public Guid BusRouteId { get; set; }
    
    /// <summary>
    /// Sıra no
    /// </summary>
    public Guid StopId { get; set; }

    /// <summary>
    /// Sefer no
    /// </summary>
    public int ExpeditionNumber { get; set; }

    /// <summary>
    /// Durak Adı
    /// </summary>
    public String BusStopName { get; set; }

    public int VehicleRoutePointId { get; set; }

    /// <summary>
    /// Hareket saati
    /// </summary>
    public DateTime DepartureTime { get; set; }

    /// <summary>
    /// Varması gereken zaman
    /// </summary>
    public DateTime TimeToArrive { get; set; }

    /// <summary>
    /// Giriş saati
    /// </summary>
    public DateTime EnterTime { get; set; }

    /// <summary>
    /// Bekleme süresi
    /// </summary>
    public DateTime WaitTime { get; set; }

    /// <summary>
    /// Çıkış saati
    /// </summary>
    public DateTime ExitTime { get; set; }

    /// <summary>
    /// İhlal süresi (sn)
    /// </summary>
    public long AlertTime { get; set; }

    /// <summary>
    /// Durak giriş bilgisi
    /// </summary>
    public bool isStopEnterInfo { get; set; }

    /// <summary>
    /// Duraklar arası süre
    /// </summary>
    public long TimeBetweenStops { get; set; }

    public DateTime UpdateTime { get; set; }

    /// <summary>
    /// Durak tipini belirlerler
    /// </summary>
    public BusStopType BusStopTypeId { get; set; }

    /// <summary>
    /// Önceki araç bilgisi
    /// </summary>
    public int PreviousVehicleId { get; set; }
    
}