namespace Triplo.Data.DataAccess;
public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly IMongoCollection<T> _collection;

    protected BaseRepository(IMongoDbContext context, string collectionName)
    {
        _collection = context.Database.GetCollection<T>(collectionName);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _collection.Find(_ => true).ToListAsync();
    }

    public virtual async Task<T> GetByIdAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", id);
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    public virtual async Task<T> CreateAsync(T entity)
    {
        await _collection.InsertOneAsync(entity);
        return entity;
    }

    public virtual async Task UpdateAsync(string id, T entity)
    {
        var filter = Builders<T>.Filter.Eq("_id", id);
        await _collection.ReplaceOneAsync(filter, entity);
    }

    public virtual async Task DeleteAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", id);
        await _collection.DeleteOneAsync(filter);
    }
}
