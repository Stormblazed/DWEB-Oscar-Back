using Domain.Film.DELETE.Entities;

namespace Domain.Film.DELETE;
public interface IDeleteFilmService
{
    public Task<DeleteFilmResponse> DeleteFilm(DeleteFilmRequest request);
}
