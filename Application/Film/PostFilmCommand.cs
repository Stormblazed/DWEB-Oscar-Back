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
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public int OndeAssitirId { get; set; }
    public int diretorId { get; set; }
    public int categoryId { get; set; }
    public int actorId { get; set; } 
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
            Nome = command.Nome,
            TotalIndicacoes = command.TotalIndicacoes,
            ondeAssistir_id = command.OndeAssitirId,
            diretor_id = command.diretorId,
            categoryId = command.categoryId,
            actorId = command.actorId
        };

         

        return await _service.PostFilmResponse(request);
    }
}
