using Api.Apis;
using Application.Actor;
using Application.Director;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Director;
public class DirectorController : ApiControllerBase
{
    [HttpGet("get-director")]
    public async Task<IActionResult> GetDirector([FromQuery] string? name) {
        var command = new GetDirectorCommand() { Nome = name };

        return await Ok(command);
    }

    [HttpPost("save-director")]
    public async Task<IActionResult> PostDirector([FromBody] PostDirectorCommand command)
    {
        return await Ok(command);
    }

    
    [HttpPut("update-director")]
    public async Task<IActionResult> PutDirector([FromBody] PutDirectorCommand command)
    {
        return await Ok(command);
    }

}
