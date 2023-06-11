using Domain.WhatchFrom.DELETE;
using Domain.WhatchFrom.DELETE.Entities;

namespace Infrastructure.WhatchFrom.DELETE;
public class DeleteWhatchFromService : IDeleteWhatchFromService
{
    private readonly Connection _connection;

    public DeleteWhatchFromService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<DeleteWhatchFromResponse> DeleteWhatchFrom(DeleteWhatchFromRequest request)
    {
         var response = new Domain.Entitie.WhatchFrom();
        response = _connection.OndeAssistir.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new DeleteWhatchFromResponse() { Message = "Não foi encontrado o registro" });

        _connection.OndeAssistir.Remove(response);
        _connection.SaveChanges();
        return await Task.FromResult(new DeleteWhatchFromResponse() { Message = "Registro deletado com sucesso!" });
    }
}