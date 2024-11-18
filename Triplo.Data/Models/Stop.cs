namespace Triplo.Data.Models;
public class Stop
{
    public string City { get; set; }          // e.g., "Dubai", "Doha"
    public string AirportCode { get; set; }   // e.g., "DXB", "DOH"
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public int StayDuration { get; set; }     // In days
    public bool IsTransitOnly { get; set; }   // True for places like AMM where they don't stay
}
