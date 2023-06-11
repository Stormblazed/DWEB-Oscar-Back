using Domain.Actor.DELETE;
using Domain.Actor.DELETE.Entities;
using Domain.Category.DELETE.Entities;

namespace Infrastructure.Actor.DELETE;
public class DeleteActorService : IDeleteActorService
{
    private readonly Connection _connection;

    public DeleteActorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<DeleteActorResponse> DeleteActor(DeleteActorRequest request)
    {
        var response = new Domain.Entitie.Actor();
        response = _connection.Atores.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new DeleteActorResponse() { Message = "Não foi encontrado o registro" });

        _connection.Atores.Remove(response);
        _connection.SaveChanges();
        return await Task.FromResult(new DeleteActorResponse() { Message = "Apagado com sucesso!" });
    }
}
