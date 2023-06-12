using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.GET;
using Domain.Film.GET.Entities;
using Domain.WhatchFrom.GET.Entities;

namespace Infrastructure.Film.GET;
public class GetFilmService : IGetFilmService
{
    private readonly Connection _connection;

    public GetFilmService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<List<GetFilmResponse>> GetFilmResponse(GetFilmRequest request)
    {
        var response = new List<Domain.Entitie.Film>();

   
        if (!String.IsNullOrEmpty(request.Nome) || request.ondeAssistir_id > 0  || request.categoryId > 0 || request.actorId > 0  || request.diretor_id > 0 || request.TotalIndicacoes > 0 || request.Codigo > 0)
            response = _connection.Filmes.Where(film => film.Id == request.Codigo || film.Nome.Contains(request.Nome) || film.TotalIndicacoes == request.TotalIndicacoes || film.ondeAssistir_id == request.ondeAssistir_id ).ToList();
        else
            response = _connection.Filmes.ToList();        

        return await Task.FromResult(response.Select(film => new GetFilmResponse() { Codigo = film.Id, ondeAssistir_id  = film.ondeAssistir_id, Nome = film.Nome, TotalIndicacoes = film.TotalIndicacoes, diretor_id = film.diretor_id }).ToList());


   
    }
}
