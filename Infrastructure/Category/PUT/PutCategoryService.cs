using Domain.Category.PUT;
using Domain.Category.PUT.Entities;

namespace Infrastructure.Category.PUT;
internal class PutCategoryService : IPutCategoryService
{
    public async Task<PutCategoryResponse> PostCategory(PutCategoryRequest request)
    {
        return await Task.FromResult(new PutCategoryResponse() { Message = "Editado com sucesso!" });
    }
}