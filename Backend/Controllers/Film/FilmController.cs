using Api.Apis;
using Application.Film;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Film;

public class FilmController : ApiControllerBase
{
    [HttpGet("get-film")]
    public async Task<IActionResult> GetFilm([FromQuery] string? name)
    {
        var command = new GetFilmCommand() { Nome = name };

        return await Ok(command);
    }

    [HttpPost("save-film")]
    public async Task<IActionResult> PostFilm([FromBody] PostFilmCommand command)
    {
        return await Ok(command);
    }


    [HttpPut("update-film")]
    public async Task<IActionResult> PutFilm([FromBody] PutFilmCommand command)
    {
        return await Ok(command);
    }

    [HttpDelete("delete-film")]
    public async Task<IActionResult> DeleteFilm([FromBody] DeleteFilmCommand command)
    {
        return await Ok(command);
    }
}
