using Domain.Director.DELETE.Entities;
using Domain.Film.DELETE;
using Domain.Film.DELETE.Entities;

namespace Infrastructure.Film.DELETE;
public class DeleteFilmService : IDeleteFilmService
{
    private readonly Connection _connection;

    public DeleteFilmService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<DeleteFilmResponse> DeleteFilm(DeleteFilmRequest request)    {

        var responseCategory = new List<Domain.Entitie.CategoryFilm>();
        responseCategory = _connection.CategoriasFilmes.Where(cat => cat.filme_id == request.Codigo).ToList();

        _connection.CategoriasFilmes.RemoveRange(responseCategory);
        _connection.SaveChanges();

        var responseAtor = new List<Domain.Entitie.FilmActor>();
        responseAtor = _connection.FilmesAtores.Where(atr => atr.filme_id == request.Codigo).ToList();

        _connection.FilmesAtores.RemoveRange(responseAtor);
        _connection.SaveChanges();

        var response = new Domain.Entitie.Film();
        response = _connection.Filmes.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new DeleteFilmResponse() { Message = "Não foi encontrado o registro" });

        _connection.Filmes.Remove(response);
        _connection.SaveChanges();

        return await Task.FromResult(new DeleteFilmResponse() { Message = "Registro deletado com sucesso!" });        
    }
}
