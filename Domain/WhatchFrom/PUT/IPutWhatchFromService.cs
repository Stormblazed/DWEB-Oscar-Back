using Domain.Category.PUT.Entities;
using Domain.WhatchFrom.PUT.Entities;

namespace Domain.WhatchFrom.PUT;
public interface IPutWhatchFromService
{
    public Task<PutWhatchFromResponse> PutWhatchFrom(PutWhatchFromRequest request);    
}
