using Domain.Film.POST.Entities;

namespace Domain.Film.POST;
public interface IPostFilmService
{
    public Task<PostFilmResponse> PostFilmResponse(PostFilmRequest request);
}
