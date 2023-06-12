using Domain.Entitie;
using Domain.Film.POST;
using Domain.Film.POST.Entities;
using Domain.WhatchFrom.POST.Entities;

namespace Infrastructure.Film.POST;
public class PostFilmService : IPostFilmService
{
    private readonly Connection _connection;

    public PostFilmService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PostFilmResponse> PostFilmResponse(PostFilmRequest request)
    {       

        _connection.Filmes.Add(new Domain.Entitie.Film { Nome = request.Nome.Trim(), TotalIndicacoes = request.TotalIndicacoes , diretor_id = request.diretor_id, ondeAssistir_id = request.ondeAssistir_id });
        _connection.SaveChanges();

        var response = new Domain.Entitie.Film();
        response = _connection.Filmes.First(film => film.Nome == request.Nome.Trim() && film.TotalIndicacoes == request.TotalIndicacoes && film.diretor_id == request.diretor_id && film.ondeAssistir_id == request.ondeAssistir_id);
               
        _connection.CategoriasFilmes.Add(new Domain.Entitie.CategoryFilm { categoria_id = request.categoryId , filme_id = response.Id });
        _connection.SaveChanges();

        _connection.FilmesAtores.Add(new Domain.Entitie.FilmActor { ator_id = request.actorId, filme_id = response.Id });
        _connection.SaveChanges();

        return await Task.FromResult(new PostFilmResponse() { Message = "Registro salvo com sucesso!" });

       
    }
}
