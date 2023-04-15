using Domain.Category.GET.Entities;

namespace Domain.Category.GET;
public interface IGetCategoryService
{
    public Task<GetCategoryResponse> GetCategory(GetCategoryRequest request);
}
