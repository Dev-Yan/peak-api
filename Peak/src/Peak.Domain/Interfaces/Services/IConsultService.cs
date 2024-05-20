using Peak.Domain.Common;
using Peak.Domain.Entities;

namespace Peak.Domain.Interfaces.Services;

public interface IConsultService
{
    Result<ConsultResponse> Consult(int id);
}