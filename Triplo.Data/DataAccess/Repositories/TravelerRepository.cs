namespace Triplo.Data.DataAccess;
public class TravelerRepository : BaseRepository<Traveler>, ITravelerRepository
{
    public TravelerRepository(IMongoDbContext context) : base(context, "Travelers") { }

    public async Task<IEnumerable<Traveler>> GetByOriginStateAsync(string state)
    {
        var filter = Builders<Traveler>.Filter.Eq(t => t.OriginState, state);
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Traveler>> GetByOriginCountryAsync(string country)
    {
        var filter = Builders<Traveler>.Filter.Eq(t => t.OriginCountry, country);
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Traveler>> GetByRouteCodeAsync(string routeCode)
    {
        var filter = Builders<Traveler>.Filter.Eq(t => t.RouteCode, routeCode);
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Traveler>> GetByFlightNumberAsync(string flightNumber, DateTime date)
    {
        var filter = Builders<Traveler>.Filter.Or(
            Builders<Traveler>.Filter.ElemMatch(t => t.OutboundJourney.Flights,
                f => f.FlightNumber == flightNumber && f.DepartureTime.Date == date.Date),
            Builders<Traveler>.Filter.ElemMatch(t => t.ReturnJourney.Flights,
                f => f.FlightNumber == flightNumber && f.DepartureTime.Date == date.Date)
        );
        return await _collection.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<Traveler>> GetByCurrentLocationAsync(string airportCode, DateTime date)
    {
        // Complex query to determine current location based on journey dates and stops
        throw new NotImplementedException();
    }
}
