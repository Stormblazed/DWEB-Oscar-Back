using Domain.Category.POST;
using Domain.Category.POST.Entities;

namespace Infrastructure.Category.POST;
public class PostCategoryService : IPostCategoryService
{
    private readonly Connection _connection;

    public PostCategoryService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PostCategoryResponse> PostCategory(PostCategoryRequest request)
    {
        _connection.Categorias.Add(new Domain.Entitie.Category { Descricao = request.Nome.Trim() });
        _connection.SaveChanges();
        return await Task.FromResult(new PostCategoryResponse()
        {
            Message = "Sucesso"
        });
    }
}

