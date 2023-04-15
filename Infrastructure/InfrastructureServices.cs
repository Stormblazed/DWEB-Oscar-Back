using Domain.Actor.GET;
using Infrastructure.Actor.GET;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServices
{
    public static IConfiguration Config { get; }
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        //services.AddSingleton<IGetSibService, GetSibServices>();
        //services.AddSingleton<IPutSibService, PutSibServices>();
        //services.AddSingleton<IPostSibService, PostSibServices>();

        services.AddSingleton<IGetActorService, GetActorService>();

        return services;
    }
}