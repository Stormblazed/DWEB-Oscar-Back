using Domain.Actor.GET;
using Domain.Actor.POST;
using Domain.Director.GET;
using Domain.Director.POST;
using Infrastructure.Actor.GET;
using Infrastructure.Actor.POST;
using Infrastructure.Director.GET;
using Infrastructure.Director.POST;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServices
{
    public static IConfiguration Config { get; }
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        //Actor
        services.AddSingleton<IGetActorService, GetActorService>();
        services.AddSingleton<IPostActorService, PostActorService>();

        //Director
        services.AddSingleton<IGetDirectorService, GetDirectorService>();
        services.AddSingleton<IPostDirectorService, PostDirectorService>();

        return services;
    }
}