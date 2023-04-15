using Domain.Director.DELETE.Entities;

namespace Domain.Director.DELETE;
public interface IDeleteDirectorService
{
    public Task<DeleteDirectorResponse> DeleteDirector(DeleteDirectorRequest request);
}
