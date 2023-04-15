using Domain.Director.GET;
using Domain.Director.GET.Entities;
using MediatR;

namespace Application.Director;
public class GetDirectorCommand : IRequest<GetDirectorResponse>
{
    public string Nome { get; set; }
}

public class GetDirectorCommandHandle : IRequestHandler<GetDirectorCommand, GetDirectorResponse>
{
    private readonly IGetDirectorService _service;

    public GetDirectorCommandHandle(IGetDirectorService service)
    {
        _service = service;
    }

    public async Task<GetDirectorResponse> Handle(GetDirectorCommand command, CancellationToken cancellationToken)
    {
        var request = new GetDirectorRequest { Nome = command.Nome };

        return await _service.GetDirectorResponse(request);

    }
}