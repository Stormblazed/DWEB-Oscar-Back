using Domain.Director.POST.Entities;
using Domain.Director.POST;
using MediatR;
using Domain.Category.POST.Entities;
using Domain.Category.POST;

namespace Application.Category;
public class PostCategoryCommand : IRequest<PostCategoryResponse>
{
    public string Nome { get; set; }
}
public class PostCategoryCommandHandle : IRequestHandler<PostCategoryCommand, PostCategoryResponse>
{
    private readonly IPostCategoryService _service;

    public PostCategoryCommandHandle(IPostCategoryService service)
    {
        _service = service;
    }

    public async Task<PostCategoryResponse> Handle(PostCategoryCommand command, CancellationToken cancellationToken)
    {
        var request = new PostCategoryRequest { Nome = command.Nome };

        return await _service.PostCategory(request);
    }
}