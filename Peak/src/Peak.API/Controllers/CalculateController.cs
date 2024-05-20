using Microsoft.AspNetCore.Mvc;
using Peak.Domain.Interfaces.Services;

namespace Peak.API.Controllers;

/// <summary>
/// Controller responsável por operar o cálculo.
/// </summary>
[ApiController]
[Route("[controller]")]
public class CalculateController : ControllerBase
{
    private readonly ICalculateService _calculateService;

    public CalculateController(ICalculateService calculateService)
    {
        _calculateService = calculateService;
    }

    /// <summary>
    /// Calcula o valor das parcelas com base no número de parcelas e no valor total.
    /// </summary>
    /// <param name="installments">Número de parcelas desejadas.</param>
    /// <param name="value">Valor total da compra.</param>
    /// <returns>Valor das parcelas calculadas.</returns>
    [HttpPost("calculate")]
    public IActionResult Calcule([FromQuery] short installments, decimal value)
    {
        var result = _calculateService.Calcule(installments, value);

        if (!result.IsSuccess) return BadRequest(result.Error);

        return Ok(result.Value);
    }
}