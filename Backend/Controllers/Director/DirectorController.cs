using Api.Apis;
using Application.Actor;
using Application.Director;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Director;
public  class DirectorController : ApiControllerBase 
{
    [HttpGet("get-director")]
    public async Task<IActionResult> GetDirector([FromQuery] string? name) {
        var command = new GetDirectorCommand(){ Nome = name };

        return await Ok(command);
    }

}
