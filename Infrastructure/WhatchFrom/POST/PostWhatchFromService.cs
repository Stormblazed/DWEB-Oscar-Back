using Domain.WhatchFrom.POST;
using Domain.WhatchFrom.POST.Entities;

namespace Infrastructure.WhatchFrom.POST;
public class PostWhatchFromService : IPostWhatchFromService
{
    public async Task<PostWhatchFromResponse> PostWhatchFrom(PostWhatchFromRequest request)
    {
        return await Task.FromResult(new PostWhatchFromResponse() { Message = "Registro salvo com sucesso!", CodigoBanco = 13 });
    }
}
