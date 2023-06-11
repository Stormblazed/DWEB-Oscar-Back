using Domain.WhatchFrom.POST;
using Domain.WhatchFrom.POST.Entities;

namespace Infrastructure.WhatchFrom.POST;
public class PostWhatchFromService : IPostWhatchFromService
{
    private readonly Connection _connection;

    public PostWhatchFromService(Connection connection)
    {
        _connection = connection;
    }

    public async Task<PostWhatchFromResponse> PostWhatchFrom(PostWhatchFromRequest request)
    {
        _connection.OndeAssistir.Add(new Domain.Entitie.WhatchFrom {  Nome = request.nome.Trim(), Plataforma = request.plataforma , Url = request.url });
        _connection.SaveChanges();
        return await Task.FromResult(new PostWhatchFromResponse() { Message = "Registro salvo com sucesso!" });
    }
}
