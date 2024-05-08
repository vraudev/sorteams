using VRAU.Sorteams.Domain.Entities.Common;

namespace VRAU.Sorteams.Domain.Entities;

public class Team : EntityBase
{
    public string GameId { get; set; }
    public virtual Game Games { get; set; }
}
