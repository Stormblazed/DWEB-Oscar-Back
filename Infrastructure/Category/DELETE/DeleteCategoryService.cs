using Domain.Category.DELETE;
using Domain.Category.DELETE.Entities;

namespace Infrastructure.Category.DELETE;
public class DeleteCategoryService : IDeleteCategoryService
{
    public async Task<DeleteCategoryResponse> DeleteCatory(DeleteCategoryRequest request)
    {
        return await Task.FromResult(new DeleteCategoryResponse() { Message = "Apagado com sucesso!" });
    }
}
