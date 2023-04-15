using Domain.Category.PUT.Entities;

namespace Domain.Category.PUT;
public interface IPutCategoryService
{
    public Task<PutCategoryResponse> PostCategory(PutCategoryRequest request);
}
