namespace Triplo.Data.DataAccess;
public interface ITravelGroupRepository : IBaseRepository<TravelGroup>
{
    Task<IEnumerable<TravelGroup>> GetActiveGroupsAsync(DateTime date);
    Task<IEnumerable<TravelGroup>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<TravelGroup> GetByCoordinatorAsync(string coordinatorPhone);
}
