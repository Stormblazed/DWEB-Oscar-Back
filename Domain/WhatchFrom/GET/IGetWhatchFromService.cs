using Domain.WhatchFrom.GET.Entities;

namespace Domain.WhatchFrom.GET;
public interface IGetWhatchFromService
{
     public Task<GetWhatchFromResponse> GetWhatchFrom(GetWhatchFromRequest request);
}
