using Domain.Actor.PUT;
using Domain.Actor.PUT.Entities;
using Domain.Category.PUT.Entities;

namespace Infrastructure.Actor.PUT;
public class PutActorService : IPutActorService
{
    private readonly Connection _connection;

    public PutActorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PutActorResponse> PutActor(PutActorRequest request)
    {
        var response = new Domain.Entitie.Actor();
        response = _connection.Atores.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new PutActorResponse() { Message = "Não foi encontrado o registro" });

        response.Nome = request.Nome;
        response.DataNascimento = request.DataNascimento;
        response.TotalIndicacoes = request.TotalIndicacoes;
        _connection.SaveChanges();

        return await Task.FromResult(new PutActorResponse() { Message = "Editado com sucesso!"});
    }
}
