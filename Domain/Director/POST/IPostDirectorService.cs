using Domain.Director.POST.Entities;

namespace Domain.Director.POST;
public interface IPostDirectorService
{
    public Task<PostDirectorResponse> PostDirector(PostDirectorRequest request);

}
