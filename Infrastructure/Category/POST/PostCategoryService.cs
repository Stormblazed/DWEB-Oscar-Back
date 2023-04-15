using Domain.Category.POST;
using Domain.Category.POST.Entities;

namespace Infrastructure.Category.POST;
public class PostCategoryService : IPostCategoryService
{
    public async Task<PostCategoryResponse> PostCategory(PostCategoryRequest request)
    {
        return await Task.FromResult(new PostCategoryResponse()
        {
            Message = "Sucesso"
        });
    }
}

