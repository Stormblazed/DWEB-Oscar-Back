using Domain.WhatchFrom.POST.Entities;

namespace Domain.WhatchFrom.POST;
public interface IPostWhatchFromService
{
    public Task<PostWhatchFromResponse> PostWhatchFrom(PostWhatchFromRequest request);
}
