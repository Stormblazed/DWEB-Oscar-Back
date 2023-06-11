using Domain.Actor.DELETE.Entities;
using Domain.Director.DELETE;
using Domain.Director.DELETE.Entities;

namespace Infrastructure.Director.DELETE;
public class DeleteDirectorService : IDeleteDirectorService
{
    private readonly Connection _connection;

    public DeleteDirectorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<DeleteDirectorResponse> DeleteDirector(DeleteDirectorRequest request)
    {
        var response = new Domain.Entitie.Director();
        response = _connection.Diretores.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new DeleteDirectorResponse() { Message = "Não foi encontrado o registro" });

        _connection.Diretores.Remove(response);
        _connection.SaveChanges();
        return await Task.FromResult(new DeleteDirectorResponse() { Message = "Registro deletado com sucesso!" });
    }
}
