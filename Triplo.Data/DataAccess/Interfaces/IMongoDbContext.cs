namespace Triplo.Data.DataAccess;
public interface IMongoDbContext
{
    IMongoDatabase Database { get; }
    IMongoCollection<Traveler> Travelers { get; }
    IMongoCollection<TravelGroup> TravelGroups { get; }
}
