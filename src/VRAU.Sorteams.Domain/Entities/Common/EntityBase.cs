namespace VRAU.Sorteams.Domain.Entities.Common;

public class EntityBase
{
    public int Id { get; set; }
    public string ApiId { get; set; }
    public bool IsRemoved { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
