using Domain.WhatchFrom.GET;
using Domain.WhatchFrom.GET.Entities;
using MediatR;

namespace Application.WhatchFrom;
public class GetWhatchFromCommand : IRequest<List<GetWhatchFromResponse>>
{  
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Url { get; set; }
    public string Plataforma { get; set; }
}



public class GetWhatchFromCommandHandle : IRequestHandler<GetWhatchFromCommand, List<GetWhatchFromResponse>>
{
    private readonly IGetWhatchFromService _service;

    public GetWhatchFromCommandHandle(IGetWhatchFromService service)
    {
        _service = service;
    }

    public async Task<List<GetWhatchFromResponse>> Handle(GetWhatchFromCommand command, CancellationToken cancellationToken)
    {
        var request = new GetWhatchFromRequest() { codigo = command.Codigo, nome = command.Nome, url = command.Url , Plataforma = command.Plataforma};

        return await _service.GetWhatchFrom(request);
    }
}

