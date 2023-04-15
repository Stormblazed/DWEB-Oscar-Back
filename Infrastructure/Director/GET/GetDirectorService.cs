using Domain.Director.GET;
using Domain.Director.GET.Entities;

namespace Infrastructure.Director.GET;
public class GetDirectorService : IGetDirectorService
{
    public Task<GetDirectorResponse> GetDirectorResponse(GetDirectorRequest request)
    {
        var response = new GetDirectorResponse() { Codigo = 1 , DataNascimento = DateTime.Now , Nome = request.Nome , TotalIndicacao = 156 };

        return Task.FromResult(response);

    }
}
