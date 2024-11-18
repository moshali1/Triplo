namespace Triplo;

public static class Extensions
{
    public static void AddApplicationServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbSettings>(
            builder.Configuration.GetSection(nameof(MongoDbSettings)));

        // MongoDB Services
        builder.Services.AddSingleton<IMongoDbContext, MongoDbContext>();
        builder.Services.AddScoped<ITravelerRepository, TravelerRepository>();
        builder.Services.AddScoped<ITravelGroupRepository, TravelGroupRepository>();
    }
}
