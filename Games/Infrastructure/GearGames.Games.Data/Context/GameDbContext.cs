using GearGames.Games.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GearGames.Games.Data.Context
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
