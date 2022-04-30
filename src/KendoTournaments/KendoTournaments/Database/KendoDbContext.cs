using KendoTournaments;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoLibrary
{
    public class KendoDbContext : DbContext
    {
        public DbSet<Group> Group { get; set; }

        public DbSet<Tournament> Tournament { get; set; }

        public DbSet<Player> Player { get; set; }

        public DbSet<MatchupPlayer> MatchupPlayer { get; set; }

        public DbSet<Matchup> Matchup { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    
}
