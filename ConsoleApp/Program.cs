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
        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {




            //context.Database.EnsureCreated();

            //GetSamurais("Before Add:");
            //AddSamurais();
            //AddBattles();
            //GetSamuraisFromAClan(1);
            //GetBattles();
            //QueryFilters();

            //InsertNewSamuraiWithAQuote();

            AddQuoteToExistingSamuraiNotTracked(18);

            //AssociarSamuraiABatalhas(1);
        }

        private static void QueryFilters()
        {
            var name = "Julie";
            var samurais = _context.Samurais.Where(s => s.Name == name).ToList();


        }
        //  private  static void AddSamurais()
        //  {
        //      var samurais = new List<Samurai>(){
        //         new Samurai { Name = "Toushiro San" },
        //         new Samurai { Name = "Himura Sensei" },
        //         new Samurai { Name = "Nakamura San" },
        //         new Samurai { Name = "Chizuka Sensei" },
        //         new Samurai { Name = "Minato Kun" },
        //         new Samurai { Name = "Mayumi Chan" }
        //      };

        //     context.Samurais.AddRange(samurais);

        //     context.SaveChanges();
            
        // }
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

       
        private static void AddBattles()
        {
            var batalha1 = new Battle { StartDate = new DateTime(1799, 1, 1), EndDate = new DateTime(1799, 1, 3), Nome = "Batalha de Okinawa" };
            var batalha2 = new Battle { StartDate = new DateTime(1799, 1, 1), EndDate = new DateTime(1799, 1, 3), Nome = "Batalha de Tokyo" };


            context.Battles.AddRange(batalha1, batalha2);

            context.SaveChanges();

        }

       
        /*
       
        
         private static void GetSamurais(string text)
        {
            var samurais = context.Samurais
                                  .Include(s=> s.SamuraiBattles)                                
                                  .ToList();

            Console.WriteLine($"{text}: Samurai count is {samurais.Count} ");

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

        }
         private static void GetSamuraisFromAClan(int ClanId)
         {
            var samurais = context.Samurais
                                  .Include(s => s.Clan)
                                  .Include(s => s.SamuraiBattles)                                
                                  .ToList();        

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

        }
        private static void GetBattles()
        {
            var battles = context.Battles.ToList();

            Console.WriteLine($"Battle count : { battles.Count }");

            Console.WriteLine();

            foreach (var battle in battles)
            {
                Console.WriteLine($"{battle.Nome} começou em {battle.StartDate} e terminou em {battle.EndDate}");

                System.Console.Write($"Samurais na batalha: \t");
                
                foreach(var sb in battle?.SamuraiBattles)
                {
                    System.Console.Write($"{sb.SamuraiId},");
                }
                System.Console.WriteLine();
            }
        }


        private static ICollection<SamuraiBattle> GetSamuraiBattles(int samuraiId)
        {
            return null;
        }
*/

        // private static void InsertNewSamuraiWithAQuote()
        // {
        //     var samurai = new Samurai(){
        //         Name = "Fausto San",
        //         Quotes = new List<Quote>{
        //             new Quote(){
        //                 Text = "Essa fera aí bicho"
        //             }
        //         }
        //     };

        //     _context.Samurais.Add(samurai);

        //     _context.SaveChanges();
        // }

        // private static void AddQuoteToExistingSamuraiNotTracked(int samuraiId){

        //     var samurai = _context.Samurais.Find(samuraiId);

        //     samurai.Quotes.Add(new Quote{
        //         Text = "Um dos maiores ORMs de todos os tempos"
        //     });

        //     using (var newcontext = new SamuraiContext()){
        //         newcontext.Samurais.Attach(samurai); // marca como tracked e unmodified
        //         newcontext.SaveChanges();

        //     }
        // }

        private static void AddQuoteToExistingSamuraiNotTracked_Easy(int samuraiId){

            var quote = new Quote{
                Text = "Um dos maiores ORMs de todos os tempos"
            };

            using (var newcontext = new SamuraiContext()){
                
                newcontext.Quotes.Add(quote); // marca como tracked
                newcontext.SaveChanges();

            }
        }
    }
}
