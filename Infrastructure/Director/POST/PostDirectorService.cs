using Domain.Director.POST;
using Domain.Director.POST.Entities;

namespace Infrastructure.Director.POST;
public class PostDirectorService : IPostDirectorService
{
    private readonly Connection _connection;

    public PostDirectorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PostDirectorResponse> PostDirector(PostDirectorRequest request){

        _connection.Diretores.Add(new Domain.Entitie.Director { Nome = request.Nome.Trim(), DataNascimento = request.DataNascimento, TotalIndicacoes = request.TotalIndicacoes });        
        _connection.SaveChanges();
        return await Task.FromResult (new PostDirectorResponse() { Message = "Ok" });
    }

    
}
