using Domain.Director.PUT.Entities;
using Domain.Film.PUT;
using Domain.Film.PUT.Entitites;
using Domain.WhatchFrom.PUT;
using Domain.WhatchFrom.PUT.Entities;

namespace Infrastructure.Film.PUT;
public class PutFilmService : IPutFilmService
{
    private readonly Connection _connection;

    public PutFilmService(Connection connection)
    {
        _connection = connection;
    }

    public  async Task<PutFilmResponse> PutFilmResponse(PutFilmRequest request)
    {     
        var responsefilm = new Domain.Entitie.Film();

        responsefilm = _connection.Filmes.Find(request.Codigo);
        if (responsefilm == null)
            return await Task.FromResult(new PutFilmResponse() { Message = "Não foi encontrado o registro" });

        responsefilm.Nome = request.Nome;
        responsefilm.TotalIndicacoes = request.TotalIndicacoes;
        responsefilm.diretor_id = request.diretor_id;
        responsefilm.ondeAssistir_id = request.ondeAssistir_id;
      

        var responseCategory = new Domain.Entitie.CategoryFilm();
        
        responseCategory = _connection.CategoriasFilmes.First(cat => cat.categoria_id == request.categoryId || cat.id == request.Codigo);
        responseCategory.categoria_id =  request.categoryId;
        responseCategory.filme_id = request.Codigo;
       

        var responseAtor = new Domain.Entitie.FilmActor();
        responseAtor = _connection.FilmesAtores.First(act => act.ator_id == request.actorId || act.filme_id == request.Codigo);        
        responseAtor.ator_id = request.actorId;
        responseCategory.filme_id = request.Codigo;
        _connection.SaveChanges();

        return await Task.FromResult(new PutFilmResponse() { Message = "Ok" });

    }
   
}
