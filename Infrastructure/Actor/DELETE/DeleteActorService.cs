using Domain.Actor.DELETE;
using Domain.Actor.DELETE.Entities;

namespace Infrastructure.Actor.DELETE;
public class DeleteActorService : IDeleteActorService
{
    public async Task<DeleteActorResponse> DeleteActor(DeleteActorRequest request)
    {
        return await Task.FromResult(new DeleteActorResponse() { Message = "Apagado com sucesso!" });
    }
}
