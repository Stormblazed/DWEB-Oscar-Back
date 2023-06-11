using Domain.Director.PUT.Entities;
using Domain.WhatchFrom.PUT;
using Domain.WhatchFrom.PUT.Entities;

namespace Infrastructure.WhatchFrom.PUT;
public class PutWhatchFromService : IPutWhatchFromService
{
    private readonly Connection _connection;

    public PutWhatchFromService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PutWhatchFromResponse> PutWhatchFrom(PutWhatchFromRequest request)
    {
        var response = new Domain.Entitie.WhatchFrom();
        response = _connection.OndeAssistir.Find(request.codigo);
        if (response == null)
            return await Task.FromResult(new PutWhatchFromResponse() { Message = "Não foi encontrado o registro" });

        response.Nome = request.nome;
        response.Url = request.url;
        response.Plataforma = request.Plataforma;
        _connection.SaveChanges();

        return await Task.FromResult(new PutWhatchFromResponse() { Message = "Ok" });        
    }
}
