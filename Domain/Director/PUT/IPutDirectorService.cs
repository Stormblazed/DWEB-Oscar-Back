using Domain.Director.PUT.Entities;

namespace Domain.Director.PUT;
public interface IPutDirectorService
{
    public Task<PutDirectorResponse> PutDirector(PutDirectorRequest request);

}
