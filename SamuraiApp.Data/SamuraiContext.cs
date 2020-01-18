using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext :  DbContext
    {
        public static readonly ILoggerFactory ConsoleLoggerFactory = LoggerFactory.Create(builder => {
            builder.AddFilter((category,level) => category == DbLoggerCategory.Database.Command.Name
                                                  && level == LogLevel.Information).AddConsole();
        });

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<SamuraiBattle> SamuraiBattles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory)
                .UseSqlServer("Server=127.0.0.1;Database=SamuraiAppData;User Id=sa;Password=Quemsabe890_$");
                //.UseSqlite("DataSource=minhabase.db");

            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                        .HasKey(s => new { s.SamuraiId, s.BattleId });
        }



    }
}