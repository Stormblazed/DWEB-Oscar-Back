using Domain.WhatchFrom.DELETE.Entities;

namespace Domain.WhatchFrom.DELETE;
public interface IDeleteWhatchFromService
{
    public Task<DeleteWhatchFromResponse> DeleteWhatchFrom(DeleteWhatchFromRequest request);
}
