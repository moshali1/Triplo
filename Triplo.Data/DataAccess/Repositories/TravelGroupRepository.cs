namespace Triplo.Data.DataAccess;
public class TravelGroupRepository : BaseRepository<TravelGroup>, ITravelGroupRepository
{
    public TravelGroupRepository(IMongoDbContext context)
        : base(context, "TravelGroups") { }

    public async Task<IEnumerable<TravelGroup>> GetActiveGroupsAsync(DateTime date)
    {
        var filter = Builders<TravelGroup>.Filter.And(
            Builders<TravelGroup>.Filter.Lte(g => g.UmrahStartDate, date),
            Builders<TravelGroup>.Filter.Gte(g => g.UmrahEndDate, date)
        );
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<TravelGroup>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
        var filter = Builders<TravelGroup>.Filter.And(
            Builders<TravelGroup>.Filter.Gte(g => g.UmrahStartDate, startDate),
            Builders<TravelGroup>.Filter.Lte(g => g.UmrahEndDate, endDate)
        );
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<TravelGroup> GetByCoordinatorAsync(string coordinatorPhone)
    {
        var filter = Builders<TravelGroup>.Filter.Eq(g => g.CoordinatorPhone, coordinatorPhone);
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }
}
