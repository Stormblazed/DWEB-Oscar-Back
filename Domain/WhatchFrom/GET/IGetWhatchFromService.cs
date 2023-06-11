using Domain.WhatchFrom.GET.Entities;

namespace Domain.WhatchFrom.GET;
public interface IGetWhatchFromService
{
     public Task<List<GetWhatchFromResponse>> GetWhatchFrom(GetWhatchFromRequest request);
}
