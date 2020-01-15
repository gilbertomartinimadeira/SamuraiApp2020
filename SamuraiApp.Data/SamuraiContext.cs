using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext :  DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder
            .UseSqlServer("Server=127.0.0.1;Database=SamuraiAppData;User Id=sa;Password=Quemsabe890_$");

            

        }
    }
}