namespace Triplo.Data.Models;
public class TravelGroup
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string GroupName { get; set; }
    public DateTime UmrahStartDate { get; set; }  // When most people arrive in Jeddah/Medina
    public DateTime UmrahEndDate { get; set; }    // When most people leave
    public string CoordinatorName { get; set; }
    public string CoordinatorPhone { get; set; }
}
