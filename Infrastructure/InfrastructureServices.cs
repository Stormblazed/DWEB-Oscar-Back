using Domain.Actor.DELETE;
using Domain.Actor.GET;
using Domain.Actor.POST;
using Domain.Actor.PUT;
using Domain.Category.DELETE;
using Domain.Category.GET;
using Domain.Category.POST;
using Domain.Category.PUT;
using Domain.Director.DELETE;
using Domain.Director.GET;
using Domain.Director.POST;
using Domain.Director.PUT;
using Domain.WhatchFrom.DELETE;
using Domain.WhatchFrom.GET;
using Domain.WhatchFrom.POST;
using Domain.WhatchFrom.PUT;
using Infrastructure.Actor.DELETE;
using Infrastructure.Actor.GET;
using Infrastructure.Actor.POST;
using Infrastructure.Actor.PUT;
using Infrastructure.Category.DELETE;
using Infrastructure.Category.GET;
using Infrastructure.Category.POST;
using Infrastructure.Category.PUT;
using Infrastructure.Director.DELETE;
using Infrastructure.Director.GET;
using Infrastructure.Director.POST;
using Infrastructure.Director.PUT;
using Infrastructure.WhatchFrom.DELETE;
using Infrastructure.WhatchFrom.GET;
using Infrastructure.WhatchFrom.POST;
using Infrastructure.WhatchFrom.PUT;
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
        services.AddSingleton<IPutActorService, PutActorService>();
        services.AddSingleton<IDeleteActorService, DeleteActorService>();

        //Director
        services.AddSingleton<IGetDirectorService, GetDirectorService>();
        services.AddSingleton<IPostDirectorService, PostDirectorService>();
        services.AddSingleton<IPutDirectorService, PutDirectorService>();
        services.AddSingleton<IDeleteDirectorService,DeleteDirectorService>();

        //Director
        services.AddSingleton<IGetCategoryService, GetCategoryService>();
        services.AddSingleton<IPostCategoryService, PostCategoryService>();
        services.AddSingleton<IPutCategoryService, PutCategoryService>();
        services.AddSingleton<IDeleteCategoryService, DeleteCategoryService>();

        //WhatchFrom
        services.AddSingleton<IGetWhatchFromService, GetWhatchFromService>();
        services.AddSingleton<IPostWhatchFromService, PostWhatchFromService>();
        services.AddSingleton<IPutWhatchFromService, PutWhatchFromService>();
        services.AddSingleton<IDeleteWhatchFromService, DeleteWhatchFromService>();

        return services;
    }
}