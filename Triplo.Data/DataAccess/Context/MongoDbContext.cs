using Microsoft.Extensions.Options;

namespace Triplo.Data.DataAccess;
public class MongoDbContext : IMongoDbContext
{
    private readonly IMongoDatabase _database;
    private readonly IMongoClient _client;

    public MongoDbContext(IOptions<MongoDbSettings> settings)
    {
        _client = new MongoClient(settings.Value.ConnectionString);
        _database = _client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoDatabase Database => _database;
    public IMongoCollection<Traveler> Travelers => _database.GetCollection<Traveler>("Travelers");
    public IMongoCollection<TravelGroup> TravelGroups => _database.GetCollection<TravelGroup>("TravelGroups");
}
