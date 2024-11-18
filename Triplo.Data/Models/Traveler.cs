namespace Triplo.Data.Models;
public class Traveler
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    // Personal Info
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PassportNumber { get; set; }
    public string Phone { get; set; }

    // Origin Details
    public string OriginCountry { get; set; } // Default "USA" for most
    public string OriginState { get; set; }   // e.g., "MN", "IL"
    public string HomeAirport { get; set; }   // e.g., "MSP", "ORD"

    // Travel Route Identifier (for easy grouping)
    public string RouteCode { get; set; }     // e.g., "MSP-ORD-AMM-DXB-DOH-JED"

    // Complete Journey
    public Journey OutboundJourney { get; set; }  // To Jeddah/Medina
    public Journey ReturnJourney { get; set; }    // Back home
}
