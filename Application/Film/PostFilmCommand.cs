using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.POST;
using Domain.Film.POST.Entities;
using Domain.WhatchFrom.GET.Entities;
using MediatR;

namespace Application.Film;
public class PostFilmCommand : IRequest<PostFilmResponse>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public GetWhatchFromResponse WhatchFromResponse { get; set; }
    public GetCategoryResponse GetCategoryResponse { get; set; }
    public GetDirectorResponse GetDirectorResponse { get; set; }
    public GetActorResponse GetActorResponse { get; set; }
}

public class PostFilmCommandHandler : IRequestHandler<PostFilmCommand, PostFilmResponse>
{
    private readonly IPostFilmService _service;

    public PostFilmCommandHandler(IPostFilmService service)
    {
        _service = service;
    }

    public async Task<PostFilmResponse> Handle(PostFilmCommand command, CancellationToken cancellationToken)
    {
        var request = new PostFilmRequest()
        {
            Codigo = command.Codigo,
            Nome = command.Nome,
            GetActorResponse = command.GetActorResponse,
            GetDirectorResponse = command.GetDirectorResponse,
            GetCategoryResponse = command.GetCategoryResponse,
            TotalIndicacoes = command.TotalIndicacoes,
            WhatchFromResponse = command.WhatchFromResponse
        };

        return await _service.PostFilmResponse(request);
    }
}
