using Api.Apis;
using Application.Film;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.Film;

public class FilmController : ApiControllerBase
{
    [HttpGet("get-film")]
    public async Task<IActionResult> GetFilm([FromQuery] string? name, [FromQuery] int codigo, [FromQuery] int totindi, [FromQuery] int diretor_id, [FromQuery] int ondeAssistir_id)
    {
        var command = new GetFilmCommand() { Nome = name, TotalIndicacoes = totindi, Codigo = codigo, diretor_id = diretor_id, ondeAssistir_id = ondeAssistir_id };

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
