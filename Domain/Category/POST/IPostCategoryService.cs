using Domain.Category.POST.Entities;

namespace Domain.Category.POST;
public interface IPostCategoryService
{
    public Task<PostCategoryResponse> PostCategory(PostCategoryRequest request);
}
