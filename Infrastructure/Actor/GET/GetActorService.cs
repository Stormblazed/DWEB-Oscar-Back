using Domain.Actor.GET;
using Domain.Actor.GET.Entities;

namespace Infrastructure.Actor.GET;
public class GetActorService : IGetActorService
{
    public async Task<GetActorResponse> GetActor(GetActorRequest request)
    {
        var response = new GetActorResponse
        {
            Codigo = 1,
            Nome = "Teste",
            DataNascimento = DateTime.Now,
            TotalIndicacoes = 2
        };

        return await Task.FromResult(response);
    }
}
