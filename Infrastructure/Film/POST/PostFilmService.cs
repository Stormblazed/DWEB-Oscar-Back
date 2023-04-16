using Domain.Film.POST;
using Domain.Film.POST.Entities;

namespace Infrastructure.Film.POST;
public class PostFilmService : IPostFilmService
{
    public async Task<PostFilmResponse> PostFilmResponse(PostFilmRequest request)
    {
        var response = new PostFilmResponse() {  Message = "Registro gravado com sucesso"};

        return await Task.FromResult(response);
    }
}
