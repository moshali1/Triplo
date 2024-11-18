namespace Triplo.Data.Models;
public class Flight
{
    public string FlightNumber { get; set; }
    public string Airline { get; set; }
    public string DepartureAirport { get; set; }  // Airport code
    public string ArrivalAirport { get; set; }    // Airport code
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string PNR { get; set; }
    public string Status { get; set; }            // For API updates
    public bool IsLocalFlight { get; set; }       // For flights like MSP-ORD
}
