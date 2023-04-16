using Domain.Film.PUT.Entitites;

namespace Domain.Film.PUT;
public interface IPutFilmService
{
    public Task<PutFilmResponse> PutFilmResponse(PutFilmRequest request);
}
