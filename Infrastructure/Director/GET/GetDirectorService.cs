using Domain.Actor.GET.Entities;
using Domain.Director.GET;
using Domain.Director.GET.Entities;

namespace Infrastructure.Director.GET;
public class GetDirectorService : IGetDirectorService
{
    private readonly Connection _connection;

    public GetDirectorService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<List<GetDirectorResponse>> GetDirectorResponse(GetDirectorRequest request)
    {
        var response = new List<Domain.Entitie.Director>();
        if (!String.IsNullOrEmpty(request.Nome) || request.DataNascimento != DateTime.MinValue || request.TotalIndicacoes > 0 || request.Codigo > 0)
            response = _connection.Diretores.Where(dire => dire.Id == request.Codigo || dire.Nome.Contains(request.Nome) || dire.TotalIndicacoes == request.TotalIndicacoes || dire.DataNascimento == request.DataNascimento).ToList();
        else
            response = _connection.Diretores.ToList();

        return await Task.FromResult(response.Select(diret => new GetDirectorResponse() { Codigo = diret.Id, DataNascimento = diret.DataNascimento, Nome = diret.Nome, TotalIndicacao = diret.TotalIndicacoes }).ToList());
        

    }
}
