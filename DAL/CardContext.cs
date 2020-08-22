using DAL.Dto;
using DAL.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public partial class CardContext : DbContext
    {
        public virtual DbSet<DbCard> Cards { get; set; }
        public virtual DbSet<DbDeck> Decks { get; set; }
        public virtual DbSet<DbDeckLink> DeckLinks { get; set; }

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new CardMap());
            modelBuilder.ApplyConfiguration(new DeckMap());
        }


    }
}
