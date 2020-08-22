using DAL;
using DAL.Context;
using DAL.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var coll = new ServiceCollection();
            coll.AddLogging(b => b.AddConsole());
            var provider = coll.BuildServiceProvider();
            var opt = new DbContextOptionsBuilder<CardContext>().UseMySql("server=localhost;port=3306;user=root;password=root;database=cardgame", x => x.ServerVersion("5.5.55-mysql"))
                .UseLoggerFactory((ILoggerFactory)provider.GetService(typeof(ILoggerFactory)));
            var p = new CardContext(opt.Options);
            var card = new DbCard
            {
                Name = "FatLooser"
            };     
            p.Cards.Add(card);
            p.SaveChanges();
            var query = p.Cards.ToList();
            foreach (var q in query)
            {
                Console.WriteLine($"{q.Name} : {q.Id}");
            }
        }
    }
}
