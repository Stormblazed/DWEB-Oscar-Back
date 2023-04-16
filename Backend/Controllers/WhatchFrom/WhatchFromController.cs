using Api.Apis;
using Application.WhatchFrom;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.WhatchFrom;

public class WhatchFromController : ApiControllerBase
{

    [HttpGet("get-whatchfrom")]
    public async Task<IActionResult> GetWhatchFrom([FromQuery] string? name)
    {
        var command = new GetWhatchFromCommand() { Nome = name };

        return await Ok(command);
    }

    [HttpPost("save-whatchfrom")]
    public async Task<IActionResult> PostWhatchFrom([FromBody] PostWhatchFromCommand command)
    {
        return await Ok(command);
    }


    [HttpPut("update-whatchfrom")]
    public async Task<IActionResult> PutWhatchFrom([FromBody] PutWhatchFromCommand command)
    {
        return await Ok(command);
    }

    [HttpDelete("delete-whatchfrom")]
    public async Task<IActionResult> DeleteWhatchFrom([FromBody] DeleteWhatchFromCommand command)
    {
        return await Ok(command);
    }
}
