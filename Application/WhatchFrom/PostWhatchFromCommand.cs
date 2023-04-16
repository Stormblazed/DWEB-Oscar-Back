using Domain.WhatchFrom.POST;
using Domain.WhatchFrom.POST.Entities;
using MediatR;

namespace Application.WhatchFrom;
public class PostWhatchFromCommand : IRequest<PostWhatchFromResponse>
{
    public string nome { get; set; }
    public string url { get; set; }
}

public class PostWhatchFromCommandHandle : IRequestHandler<PostWhatchFromCommand, PostWhatchFromResponse>
{
    private readonly IPostWhatchFromService _service;

    public PostWhatchFromCommandHandle(IPostWhatchFromService service)
    {
        _service = service;
    }

    public Task<PostWhatchFromResponse> Handle(PostWhatchFromCommand command, CancellationToken cancellationToken)
    {
        var request = new PostWhatchFromRequest() { nome = command.nome, url = command.url };

        return _service.PostWhatchFrom(request);
    }
}
