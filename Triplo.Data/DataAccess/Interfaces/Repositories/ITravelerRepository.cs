namespace Triplo.Data.DataAccess;
public interface ITravelerRepository
{
    Task<IEnumerable<Traveler>> GetByCurrentLocationAsync(string airportCode, DateTime date);
    Task<IEnumerable<Traveler>> GetByFlightNumberAsync(string flightNumber, DateTime date);
    Task<IEnumerable<Traveler>> GetByOriginCountryAsync(string country);
    Task<IEnumerable<Traveler>> GetByOriginStateAsync(string state);
    Task<IEnumerable<Traveler>> GetByRouteCodeAsync(string routeCode);
}