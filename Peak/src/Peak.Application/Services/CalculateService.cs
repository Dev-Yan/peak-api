using Peak.Domain.Common;
using Peak.Domain.Entities;
using Peak.Domain.Interfaces.Services;

namespace Peak.Application.Services;

public class CalculateService : ICalculateService
{
    private const decimal AdditionalFee = 1.05m;

    public Result<CalculateResponse> Calcule(short installments, decimal value)
    {
        if (installments <= 0 || value <= 0)
        {
            return Result<CalculateResponse>.Failure("Installments or value must be greater than zero");
        }

        decimal totalValue = CalculateTotalValue(installments, value);

        return Result<CalculateResponse>.Success(new CalculateResponse { Value = totalValue });
    }

    private static decimal CalculateTotalValue(short installments, decimal value)
    {
        return (value * installments) * AdditionalFee;
    }
}