using Domain.Actor.GET;
using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;

namespace Infrastructure.Actor.GET;
public class GetActorService : IGetActorService
{
    private readonly Connection _connection;

    public GetActorService(Connection connection)
    {
        _connection = connection;
    }
    

    public async Task<List<GetActorResponse>> GetActor(GetActorRequest request)
    {
        
        var response = new List<Domain.Entitie.Actor>();
        if (!String.IsNullOrEmpty(request.Name) || request.DataNascimento != DateTime.MinValue || request.TotalIndicacoes > 0 || request.Codigo > 0)
            response = _connection.Atores.Where(atores => atores.Id == request.Codigo || atores.Nome.Contains(request.Name) || atores.TotalIndicacoes == request.TotalIndicacoes || atores.DataNascimento == request.DataNascimento).ToList();
        else
            response = _connection.Atores.ToList();

        return await Task.FromResult(response.Select(atr => new GetActorResponse() { Codigo = atr.Id, DataNascimento = atr.DataNascimento , Nome = atr.Nome , TotalIndicacoes = atr.TotalIndicacoes }).ToList());
    }
}

