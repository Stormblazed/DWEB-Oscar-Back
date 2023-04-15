using Domain.Category.PUT;
using Domain.Category.PUT.Entities;
using MediatR;

namespace Application.Category;
public class PutCategoryCommand : IRequest<PutCategoryResponse>
{
    public int Codigo { get; set; }

    public string Nome { get; set; }

}

public class PutCategoryCommandHandle : IRequestHandler<PutCategoryCommand, PutCategoryResponse>
{
    private readonly IPutCategoryService _service;

    public PutCategoryCommandHandle(IPutCategoryService service)
    {
        _service = service;
    }

    public async Task<PutCategoryResponse> Handle(PutCategoryCommand command, CancellationToken cancellationToken)
    {
        var request = new PutCategoryRequest() { Codigo = command.Codigo, Nome = command.Nome };

        return await _service.PostCategory(request);
    }
}
