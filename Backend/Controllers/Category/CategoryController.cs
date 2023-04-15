using Api.Apis;
using Application.Category;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Category;

public class CategoryController : ApiControllerBase
{
    [HttpGet("get-category")]
    public async Task<IActionResult> GetActor([FromQuery] string? name)
    {
        var command = new GetCategoryCommand()
        {
            Nome = name
        };

        return await Ok(command);
    }

    [HttpPost("create-category")]
    public async Task<IActionResult> PostActor([FromBody] PostCategoryCommand command)
    {
        return await Ok(command);
    }

    [HttpPut("update-category")]
    public async Task<IActionResult> PutActor([FromBody] PutCategoryCommand command)
    {
        return await Ok(command);
    }

    [HttpDelete("delete-category")]
    public async Task<IActionResult> DeleteActor([FromBody] DeleteCategoryCommand command)
    {
        return await Ok(command);
    }
}
