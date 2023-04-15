using Domain.Category.GET;
using Domain.Category.GET.Entities;

namespace Infrastructure.Category.GET;
public class GetCategoryService : IGetCategoryService
{
    public async Task<GetCategoryResponse> GetCategory(GetCategoryRequest request)
    {
        var response = new GetCategoryResponse
        {
            Codigo = 1,
            Nome = "Ação"
        };


        return await Task.FromResult(response);
    }
   
}

