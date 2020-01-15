﻿using System;
using SamuraiApp.Data;
using SamuraiApp.Domain;
using System.Linq;

namespace ConsoleApp
{
    
    public class Program
    {    
        private static SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();

            GetSamurais("Before Add:");
            AddSamurai();

            GetSamurais("After Add:");

            Console.WriteLine("press Any key...");
            Console.ReadKey();
        }

        private  static void AddSamurai(){
            var samurai = new Samurai { Name = "PedrãoSan" };

            context.Samurais.Add(samurai);
            context.SaveChanges();
            
        }

        private static void GetSamurais(string text)
        {
            var samurais = context.Samurais.ToList();

            Console.WriteLine($"{text}: Samurai count is {samurais.Count} ");

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

        }

    }
}