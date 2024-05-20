using Microsoft.AspNetCore.Mvc;
using Peak.Domain.Interfaces.Services;

namespace Peak.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ConsultController : ControllerBase
{
    private readonly IConsultService _consultService;

    public ConsultController(IConsultService consultService)
    {
        _consultService = consultService;
    }

    [HttpGet("{id}")]
    public IActionResult Consult(int id)
    {
        var result = _consultService.Consult(id);

        if (!result.IsSuccess) return NotFound(result.Error);

        return Ok(result.Value);
    }
}