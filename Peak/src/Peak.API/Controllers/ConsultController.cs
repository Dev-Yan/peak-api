using Microsoft.AspNetCore.Mvc;
using Peak.Domain.Interfaces.Services;

namespace Peak.API.Controllers;

/// <summary>
/// Controller responsável por consultar pessoas.
/// </summary>
[ApiController]
[Route("[controller]")]
public class ConsultController : ControllerBase
{
    private readonly IConsultService _consultService;

    public ConsultController(IConsultService consultService)
    {
        _consultService = consultService;
    }

    /// <summary>
    /// Consulta uma pessoa pelo Id.
    /// </summary>
    /// <param name="id">Id da pessoa a ser consultada.</param>
    /// <returns>Informações da pessoa consultada.</returns>
    [HttpGet("{id}")]
    public IActionResult Consult(int id)
    {
        var result = _consultService.Consult(id);

        if (!result.IsSuccess) return NotFound(result.Error);

        return Ok(result.Value);
    }
}