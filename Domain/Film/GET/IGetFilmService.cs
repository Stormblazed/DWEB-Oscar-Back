using Domain.Film.GET.Entities;

namespace Domain.Film.GET;
public interface IGetFilmService
{
    public Task<List<GetFilmResponse>> GetFilmResponse(GetFilmRequest request);
}
