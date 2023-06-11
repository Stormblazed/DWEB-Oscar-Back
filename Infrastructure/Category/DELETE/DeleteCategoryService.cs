using Domain.Category.DELETE;
using Domain.Category.DELETE.Entities;
using Domain.Category.PUT.Entities;

namespace Infrastructure.Category.DELETE;
public class DeleteCategoryService : IDeleteCategoryService
{
    private readonly Connection _connection;

    public DeleteCategoryService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<DeleteCategoryResponse> DeleteCatory(DeleteCategoryRequest request)
    {
        var response = new Domain.Entitie.Category();
        response = _connection.Categorias.Find(request.Codigo);
        if (response == null)
            return await Task.FromResult(new DeleteCategoryResponse() { Message = "Não foi encontrado o registro" });

        _connection.Categorias.Remove(response);
        _connection.SaveChanges();

        return await Task.FromResult(new DeleteCategoryResponse() { Message = "Apagado com sucesso!" });
    }
}
