using Domain.Actor.POST;
using Domain.Actor.POST.Entities;
using Domain.Category.POST.Entities;

namespace Infrastructure.Actor.POST;
public class PostActorService : IPostActorService
{
    private readonly Connection _connection;

    public PostActorService(Connection connection)
    {
        _connection = connection;
    }    

    public async Task<PostActorResponse> PostActor(PostActorRequest request)
    {
        _connection.Atores.Add(new Domain.Entitie.Actor { Nome = request.Nome.Trim() , DataNascimento = request.DataNascimento , TotalIndicacoes = request.TotalIndicacoes });
        _connection.SaveChanges();
        return await Task.FromResult(new PostActorResponse() { 
            Message = "Sucesso" 
        });
    }
}
