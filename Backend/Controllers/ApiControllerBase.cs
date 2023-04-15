using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Apis;
[Route("api/[controller]")]
[ApiController]
public class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null!;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

    public async Task<IActionResult> Ok<T>(T command)
    {
        try
        {
            return base.Ok(await Mediator.Send(command));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    public async Task<IActionResult> Created<T>(T command)
    {
        try
        {
            return base.Created("", await Mediator.Send(command));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    public IActionResult AcceptedEmpty<T>(T command)
    {
        _ = Task.Run(() => Mediator.Send(command));
        return base.Accepted();
    }

    public async Task<IActionResult> Accepted<T>(T command)
    {
        try
        {
            return base.Accepted(await Mediator.Send(command));
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    public async Task<IActionResult> NoContent<T>(T command)
    {
        try
        {
            await Mediator.Send(command);
            return base.NoContent();
        }
        catch (Exception e)
        {
            return HandleException(e);
        }
    }

    protected IActionResult HandleException(Exception e)
    {
        return base.StatusCode(500, new Exception(e.Message));
    }
}