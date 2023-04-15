using Domain.Director.POST;
using Domain.Director.POST.Entities;

namespace Infrastructure.Director.POST;
public class PostDirectorService : IPostDirectorService
{
    public async Task<PostDirectorResponse> PostDirector(PostDirectorRequest request){
    
        return await Task.FromResult (new PostDirectorResponse() { Message = "Ok" });
    }

    
}
