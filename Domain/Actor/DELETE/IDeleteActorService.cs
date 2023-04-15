using Domain.Actor.DELETE.Entities;

namespace Domain.Actor.DELETE;
public interface IDeleteActorService
{
    public Task<DeleteActorResponse> DeleteActor(DeleteActorRequest request);
}
