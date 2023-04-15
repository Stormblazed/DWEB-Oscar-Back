using Domain.Director.PUT;
using Domain.Director.PUT.Entities;

namespace Infrastructure.Director.PUT;
public class PutDirectorService : IPutDirectorService
{

    public async Task<PutDirectorResponse> PutDirector(PutDirectorRequest request)
    {
        return await Task.FromResult(new PutDirectorResponse() { Message = "Ok"  });

    }
}
