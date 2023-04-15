using Domain.Actor.GET.Entities;

namespace Domain.Actor.GET;

public interface IGetActorService
{
    public Task<GetActorResponse> GetActor(GetActorRequest request);
}
