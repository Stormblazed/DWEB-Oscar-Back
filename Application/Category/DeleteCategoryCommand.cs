using Domain.Category.DELETE;
using Domain.Category.DELETE.Entities;
using MediatR;

namespace Application.Category;
public class DeleteCategoryCommand : IRequest<DeleteCategoryResponse>
{
    public int Codigo { get; set; }
}

public class DeleteCategoryCommandHandle : IRequestHandler<DeleteCategoryCommand, DeleteCategoryResponse>
{
    private readonly IDeleteCategoryService _service;

    public DeleteCategoryCommandHandle(IDeleteCategoryService service)
    {
        _service = service;
    }

    public Task<DeleteCategoryResponse> Handle(DeleteCategoryCommand command, CancellationToken cancellationToken)
    {
        var request = new DeleteCategoryRequest()
        {
            Codigo = command.Codigo,          
        };

        return _service.DeleteCatory(request);
    }
}

