using Microsoft.EntityFrameworkCore;
using VRAU.Sorteams.Domain.Entities;

namespace VRAU.Sorteams.Domain.Context;

public class SorteamsContext : DbContext
{
    public SorteamsContext(DbContextOptions<SorteamsContext> options) : base(options)
    {
    }

    public DbSet<Sport> Sports { get; set; }
    public DbSet<Configuration> Configurations { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
}
