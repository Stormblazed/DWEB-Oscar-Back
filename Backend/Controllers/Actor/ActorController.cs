using Api.Apis;
using Application.Actor;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Actor;

public class ActorController : ApiControllerBase
{
    [HttpGet("get-actor")]
    public async Task<IActionResult> GetActor([FromQuery] string? name, [FromQuery] int codigo, [FromQuery] int totalIndicacao, [FromQuery] DateTime datnascimeto)
    {
        var command = new GetActorCommand() {
           id = codigo,
           datnascimento = datnascimeto,
           totalint = totalIndicacao,
           Name = name
        };

        return await Ok(command);
    }

    [HttpPost("create-actor")]
    public async Task<IActionResult> PostActor([FromBody] PostActorCommand command)
    {
        return await Ok(command);
    }

    [HttpPut("update-actor")]
    public async Task<IActionResult> PutActor([FromBody] PutActorCommand command)
    {
        return await Ok(command);
    }

    [HttpDelete("delete-actor")]
    public async Task<IActionResult> DeleteActor([FromBody] DeleteActorCommand command)
    {
        return await Ok(command);
    }
}
