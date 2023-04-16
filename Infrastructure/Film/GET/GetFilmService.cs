using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.GET;
using Domain.Film.GET.Entities;
using Domain.WhatchFrom.GET.Entities;

namespace Infrastructure.Film.GET;
public class GetFilmService : IGetFilmService
{
    public async Task<GetFilmResponse> GetFilmResponse(GetFilmRequest request)
    {
        return await Task.FromResult(new GetFilmResponse
        {
            Codigo = 1,
            GetActorResponse = new GetActorResponse() { Codigo = 1, DataNascimento = DateTime.Now, Nome = "Teste", TotalIndicacoes = 4 },
            GetCategoryResponse = new GetCategoryResponse() { Codigo = 2, Nome = "Terror" },
            GetDirectorResponse = new GetDirectorResponse() { Codigo = 2, DataNascimento = DateTime.Now, Nome = "Sr teste", TotalIndicacao = 45 },
            Nome = "teste",
            TotalIndicacoes = 23,
            WhatchFromResponse = new GetWhatchFromResponse() { Codigo = 1, Nome = "Netflix", Url = "netflix.com.br" }
        });
    }
}
