using Domain.Category.DELETE.Entities;

namespace Domain.Category.DELETE;
public interface IDeleteCategoryService
{
    public Task<DeleteCategoryResponse> DeleteCatory(DeleteCategoryRequest request);
}
