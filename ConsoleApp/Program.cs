using System;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    
    public class Program
    {    
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {



            //context.Database.EnsureCreated();

            //GetSamurais("Before Add:");
            //AddSamurais();
            //AddBattles();
            //GetSamurais("Samurais:");
            //GetBattles();


            //AssociarSamuraiABatalhas(1);
        }
        /*
        private static void AssociarSamuraiABatalhas(int samuraiId)
        {
            var samurai = context.Samurais.FirstOrDefault(s => s.Id == samuraiId);
            samurai.SamuraiBattles = new List<SamuraiBattle>();

            var battles = context.Battles.ToList();

            foreach (var battle in battles)
            {
                samurai.SamuraiBattles.Add(new SamuraiBattle() { BattleId = battle.BattleId, SamuraiId = samurai.Id });
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private  static void AddSamurais(){
            var samurai1 = new Samurai { Name = "Toushiro San" };
            var samurai2 = new Samurai { Name = "Himura Sensei" };

            context.Samurais.AddRange(samurai1,samurai2);

            context.SaveChanges();
            
        }
        private static void AddBattles()
        {
            var batalha1 = new Battle { StartDate = new DateTime(1799, 1, 1), EndDate = new DateTime(1799, 1, 3), Nome = "Batalha de Okinawa" };
            var batalha2 = new Battle { StartDate = new DateTime(1799, 1, 1), EndDate = new DateTime(1799, 1, 3), Nome = "Batalha de Tokyo" };


            context.Battles.AddRange(batalha1, batalha2);

            context.SaveChanges();

        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.Include(s=> s.SamuraiBattles).ToList();

            Console.WriteLine($"{text}: Samurai count is {samurais.Count} ");

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

        }
        /*
        private static void GetBattles()
        {
            var battles = context.Battles.ToList();

            Console.WriteLine($"Battle count : { battles.Count }");

            Console.WriteLine();

            foreach (var battle in battles)
            {
                Console.WriteLine($"{battle.Nome} começou em {battle.StartDate} e terminou em {battle.EndDate}");
            }
            
        }
        */
        private static ICollection<SamuraiBattle> GetSamuraiBattles(int samuraiId)
        {
            return null;
        }

    }
}
