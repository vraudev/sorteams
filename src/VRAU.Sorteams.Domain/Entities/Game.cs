using VRAU.Sorteams.Domain.Entities.Common;

namespace VRAU.Sorteams.Domain.Entities;

public class Game : EntityBase
{
    public string EventName { get; set; }
    public int UserId { get; set; }
    public int ConfigurationId { get; set; }
    public int SportId { get; set; }

    public virtual Sport Sports { get; set; }
    public virtual ICollection<Configuration> Configurations { get; set; }
}
