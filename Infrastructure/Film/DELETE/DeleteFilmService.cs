using Domain.Film.DELETE;
using Domain.Film.DELETE.Entities;

namespace Infrastructure.Film.DELETE;
public class DeleteFilmService : IDeleteFilmService
{
    public async Task<DeleteFilmResponse> DeleteFilm(DeleteFilmRequest request)    {
        return await Task.FromResult(new DeleteFilmResponse() { Message = "Registro deletado com sucesso." });
    }
}
