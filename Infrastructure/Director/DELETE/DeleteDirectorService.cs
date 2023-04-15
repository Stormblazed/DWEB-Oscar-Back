using Domain.Director.DELETE;
using Domain.Director.DELETE.Entities;

namespace Infrastructure.Director.DELETE;
public class DeleteDirectorService : IDeleteDirectorService
{
    public async Task<DeleteDirectorResponse> DeleteDirector(DeleteDirectorRequest request)
    {
        return await Task.FromResult(new DeleteDirectorResponse() { Message = "Registro deletado com sucesso!" });
    }
}
