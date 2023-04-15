using Domain.Actor.POST.Entities;

namespace Domain.Actor.POST;
public interface IPostActorService
{
    public Task<PostActorResponse> PostActor(PostActorRequest request);
}