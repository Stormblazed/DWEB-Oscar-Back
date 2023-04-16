using Domain.WhatchFrom.PUT;
using Domain.WhatchFrom.PUT.Entities;

namespace Infrastructure.WhatchFrom.PUT;
public class PutWhatchFromService : IPutWhatchFromService
{
    public Task<PutWhatchFromResponse> PutWhatchFrom(PutWhatchFromRequest request)
    {
        return Task.FromResult(new PutWhatchFromResponse { CodigoBanco = 1546, Message = "Registro alterado com sucesso." });
    }
}
