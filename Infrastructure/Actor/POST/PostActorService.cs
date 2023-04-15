using Domain.Actor.POST;
using Domain.Actor.POST.Entities;

namespace Infrastructure.Actor.POST;
public class PostActorService : IPostActorService
{
    public async Task<PostActorResponse> PostActor(PostActorRequest request)
    {
        return await Task.FromResult(new PostActorResponse() { 
            Message = "Sucesso" 
        });
    }
}
