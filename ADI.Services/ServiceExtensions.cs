using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ADI.Services;

public static class ServiceExtensions
{
    public static IServiceCollection AddLibraryApiClient(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var apiToUse = configuration["ApiToUse"];

        if (apiToUse == "Deichman")
        {
            serviceCollection.AddTransient<ILibraryApiClient, DeichmanApiClient>();    
        }
        else
        {
            serviceCollection.AddSingleton<ILibraryApiClient, OpenLibraryApiClient>();    
        }

        return serviceCollection;
    }
}