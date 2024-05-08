using VRAU.Sorteams.Domain.Entities.Common;

namespace VRAU.Sorteams.Domain.Entities;

public class Player : EntityBase
{
    public string Name { get; set; }
    public string TeamId { get; set; }
    public virtual Team Teams { get; set; }
}
