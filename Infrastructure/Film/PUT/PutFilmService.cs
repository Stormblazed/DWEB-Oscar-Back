using Domain.Film.PUT;
using Domain.Film.PUT.Entitites;
using Domain.WhatchFrom.PUT;
using Domain.WhatchFrom.PUT.Entities;

namespace Infrastructure.Film.PUT;
public class PutFilmService : IPutFilmService
{
    public  async Task<PutFilmResponse> PutFilmResponse(PutFilmRequest request)
    {
        var response = new PutFilmResponse() { Message = "Registro alterado com sucesso" };

        return await Task.FromResult(response);
    }
   
}
