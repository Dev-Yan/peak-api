using Peak.Domain.Common;
using Peak.Domain.Entities;
using Peak.Domain.Interfaces.Repositories;
using Peak.Domain.Interfaces.Services;

namespace Peak.Application.Services;

public class ConsultService : IConsultService
{
    private readonly IConsultRepository _consultRepository;

    public ConsultService(IConsultRepository consultRepository)
    {
        _consultRepository = consultRepository;
    }

    public Result<ConsultResponse> Consult(int id)
    {
        var consult = _consultRepository.GetNameById(id);

        if (consult is null)
        {
            return Result<ConsultResponse>.Failure("Person is not found.");
        }

        ConsultResponse consultResponse = new() { Name = consult };

        return Result<ConsultResponse>.Success(consultResponse);
    }
}