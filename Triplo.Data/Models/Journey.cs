namespace Triplo.Data.Models;
public class Journey
{
    public DateTime StartDate { get; set; }      // First flight date
    public DateTime EndDate { get; set; }        // Last flight date
    public List<Stop> Stops { get; set; } = new();
    public List<Flight> Flights { get; set; } = new();
}
