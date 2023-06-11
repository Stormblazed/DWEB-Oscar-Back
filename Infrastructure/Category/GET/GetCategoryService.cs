using Domain.Category.GET;
using Domain.Category.GET.Entities;
using Domain.Entitie;
using System.Linq;

namespace Infrastructure.Category.GET;
public class GetCategoryService : IGetCategoryService
{
    private readonly Connection _connection;

    public GetCategoryService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<List<GetCategoryResponse>> GetCategory(GetCategoryRequest request)
    {
        
        var response = new List<Domain.Entitie.Category>();
        if (!String.IsNullOrEmpty(request.Nome) || request.Codigo > 0)
            response = _connection.Categorias.Where(categoria => categoria.Id == request.Codigo || categoria.Descricao.Contains(request.Nome)).ToList();
        else
            response = _connection.Categorias.ToList();

        return await Task.FromResult(response.Select(cat => new GetCategoryResponse() { Codigo = cat.Id , Nome = cat.Descricao }).ToList());
    }
   
}

