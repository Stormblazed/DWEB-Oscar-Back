using Application.Actor;
using Domain.Director.DELETE;
using Domain.Director.DELETE.Entities;
using MediatR;
using System.Globalization;

namespace Application.Director;
public class DeleteDirectorCommand : IRequest<DeleteDirectorResponse>
{
    public int Codigo { get; set; }
}

public class DeleteDirectorCommandHandle : IRequestHandler<DeleteDirectorCommand, DeleteDirectorResponse>
{
    private readonly IDeleteDirectorService _service;

    public DeleteDirectorCommandHandle(IDeleteDirectorService service)
    {
        _service = service;
    }


    public Task<DeleteDirectorResponse> Handle(DeleteDirectorCommand command, CancellationToken cancellationToken)
    {
        var request = new DeleteDirectorRequest()
        {
            Codigo = command.Codigo
        };

        return _service.DeleteDirector(request);

    }
}
