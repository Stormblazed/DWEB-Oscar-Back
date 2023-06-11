using Domain.Director.GET.Entities;
using Domain.WhatchFrom.GET;
using Domain.WhatchFrom.GET.Entities;

namespace Infrastructure.WhatchFrom.GET;
public class GetWhatchFromService : IGetWhatchFromService
{
    private readonly Connection _connection;

    public GetWhatchFromService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<List<GetWhatchFromResponse>> GetWhatchFrom(GetWhatchFromRequest request)
    {

        var response = new List<Domain.Entitie.WhatchFrom>();
        if (!String.IsNullOrEmpty(request.url) || !String.IsNullOrEmpty(request.Plataforma) || !String.IsNullOrEmpty(request.nome) || request.codigo > 0)
            response = _connection.OndeAssistir.Where(dire => dire.Id == request.codigo || dire.Nome.Contains(request.nome) || dire.Plataforma == request.Plataforma || dire.Url == request.url).ToList();
        else
            response = _connection.OndeAssistir.ToList();


        return await Task.FromResult(response.Select(watch => new GetWhatchFromResponse() { Codigo = watch.Id, Url = watch.Url, Nome = watch.Nome, Plataforma = watch.Plataforma }).ToList());
        
    }
}
