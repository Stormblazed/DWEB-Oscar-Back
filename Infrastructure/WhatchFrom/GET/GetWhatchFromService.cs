using Domain.WhatchFrom.GET;
using Domain.WhatchFrom.GET.Entities;

namespace Infrastructure.WhatchFrom.GET;
public class GetWhatchFromService : IGetWhatchFromService
{
    public async Task<GetWhatchFromResponse> GetWhatchFrom(GetWhatchFromRequest request)
    {
        return await Task.FromResult(new GetWhatchFromResponse() { Codigo = 1, Nome = "Teste Testado", Url = "google.com.br" });
    }
}
