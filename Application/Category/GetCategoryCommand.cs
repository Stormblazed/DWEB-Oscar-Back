using Domain.Category.GET;
using Domain.Category.GET.Entities;
using MediatR;

namespace Application.Category;
public class GetCategoryCommand : IRequest<List<GetCategoryResponse>>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
}

public class GetCategoryCommandHandle : IRequestHandler<GetCategoryCommand, List<GetCategoryResponse>>
{
    private readonly IGetCategoryService _service;

    public GetCategoryCommandHandle(IGetCategoryService service)
    {
        _service = service;
    }

    public Task<List<GetCategoryResponse>> Handle(GetCategoryCommand command, CancellationToken cancellationToken)
    {
        var request = new GetCategoryRequest() { Codigo = command.Codigo, Nome = command.Nome };

        return _service.GetCategory(request);

    }
}
