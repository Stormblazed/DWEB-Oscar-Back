using Domain.Film.DELETE;
using Domain.Film.DELETE.Entities;
using MediatR;

namespace Application.Film;
public class DeleteFilmCommand : IRequest<DeleteFilmResponse>
{
    public int Codigo { get; set; }
}

public class DeleteFilmCommandHandle : IRequestHandler<DeleteFilmCommand, DeleteFilmResponse>
{
    private readonly IDeleteFilmService _service;

    public DeleteFilmCommandHandle(IDeleteFilmService service)
    {
        _service = service;
    }

    public Task<DeleteFilmResponse> Handle(DeleteFilmCommand command, CancellationToken cancellationToken)
    {
        var request = new DeleteFilmRequest() { Codigo = command.Codigo };

        return _service.DeleteFilm(request);

    }
}
