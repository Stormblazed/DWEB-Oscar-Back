using Api.Apis;
using Application.Actor;
using Domain.Actor.GET.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Actor;

public class ActorController : ApiControllerBase
{
    [HttpGet("get-actor")]
    public async Task<IActionResult> GetActor([FromQuery] string? name)
    {
        var command = new GetActorCommand() { 
            Name = name
        };

        return await Ok(command);
    }
}
