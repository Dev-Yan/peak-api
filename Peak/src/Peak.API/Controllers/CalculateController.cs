using Microsoft.AspNetCore.Mvc;
using Peak.Domain.Interfaces.Services;

namespace Peak.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    private readonly ICalculateService _calculateService;

    public CalculateController(ICalculateService calculateService)
    {
        _calculateService = calculateService;
    }

    [HttpPost("calculate")]
    public IActionResult Calcule([FromQuery] short installments, decimal value)
    {
        var result = _calculateService.Calcule(installments, value);

        if (!result.IsSuccess) return BadRequest(result.Error);

        return Ok(result.Value);
    }
}