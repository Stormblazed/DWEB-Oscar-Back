using Domain.Category.PUT;
using Domain.Category.PUT.Entities;

namespace Infrastructure.Category.PUT;
internal class PutCategoryService : IPutCategoryService
{
    private readonly Connection _connection;

    public PutCategoryService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PutCategoryResponse> PostCategory(PutCategoryRequest request)
    {
        var response = new Domain.Entitie.Category();     
        response = _connection.Categorias.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new PutCategoryResponse() { Message = "Não foi encontrado o registro" });

        response.Descricao = request.Nome;        
        _connection.SaveChanges();

        return await Task.FromResult(new PutCategoryResponse() { Message = "Editado com sucesso!" });
    }
}