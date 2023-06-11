using Domain.Actor.PUT.Entities;
using Domain.Director.PUT;
using Domain.Director.PUT.Entities;

namespace Infrastructure.Director.PUT;
public class PutDirectorService : IPutDirectorService
{
    private readonly Connection _connection;

    public PutDirectorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PutDirectorResponse> PutDirector(PutDirectorRequest request)
    {
        var response = new Domain.Entitie.Director();
        response = _connection.Diretores.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new PutDirectorResponse() { Message = "Não foi encontrado o registro" });

        response.Nome = request.Nome;
        response.DataNascimento = request.DataNascimento;
        response.TotalIndicacoes = request.TotalIndicacoes;
        _connection.SaveChanges();

        return await Task.FromResult(new PutDirectorResponse() { Message = "Ok"  });

    }
}
