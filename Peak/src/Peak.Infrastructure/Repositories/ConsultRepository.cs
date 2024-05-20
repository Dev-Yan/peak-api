using Peak.Domain.Interfaces.Repositories;

namespace Peak.Infrastructure.Repositories;

public class ConsultRepository : IConsultRepository
{
    private static readonly List<KeyValuePair<int, string>> List =
    [
        new KeyValuePair<int, string>(1, "João"),
        new KeyValuePair<int, string>(2, "Maria"),
        new KeyValuePair<int, string>(3, "Ana")
    ];

    public string GetNameById(int id)
    {
        var item = List.FirstOrDefault(x => x.Key == id);
        return item.Value;
    }
}