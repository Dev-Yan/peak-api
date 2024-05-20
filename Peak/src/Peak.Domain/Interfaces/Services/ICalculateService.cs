using Peak.Domain.Common;
using Peak.Domain.Entities;

namespace Peak.Domain.Interfaces.Services;

public interface ICalculateService
{
    Result<CalculateResponse> Calcule(short installments, decimal value);
}