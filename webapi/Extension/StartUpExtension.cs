using Chat.Data;

namespace Chat.WebApi;

public static class StartUpExtension
{
    public static void AddServices(this IServiceCollection services)
    {

        services.AddScoped<IUnitOfWork,UnitOfWork>();

        services.AddScoped<IGenericRepository<User>,GenericRepository<User>>();
    }

}
