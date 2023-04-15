using Domain.Actor.PUT.Entities;

namespace Domain.Actor.PUT;
public interface IPutActorService
{
    public Task<PutActorResponse> PutActor(PutActorRequest request);
}
