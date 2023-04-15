using Domain.Actor.PUT;
using Domain.Actor.PUT.Entities;

namespace Infrastructure.Actor.PUT;
public class PutActorService : IPutActorService
{
    public async Task<PutActorResponse> PutActor(PutActorRequest request)
    {
        return await Task.FromResult(new PutActorResponse() { Message = "Editado com sucesso!"});
    }
}
