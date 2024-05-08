using VRAU.Sorteams.Domain.Entities.Common;

namespace VRAU.Sorteams.Domain.Entities;

public class Configuration : EntityBase
{
    public string Name { get; set; }
    public int Value { get; set; }
}
