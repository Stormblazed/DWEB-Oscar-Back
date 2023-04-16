using Domain.WhatchFrom.DELETE;
using Domain.WhatchFrom.DELETE.Entities;

namespace Infrastructure.WhatchFrom.DELETE;
public class DeleteWhatchFromService : IDeleteWhatchFromService
{
    public async Task<DeleteWhatchFromResponse> DeleteWhatchFrom(DeleteWhatchFromRequest request)
    {
        return await Task.FromResult(new DeleteWhatchFromResponse() { Message = "Registro deletado com sucesso!" });
    }
}