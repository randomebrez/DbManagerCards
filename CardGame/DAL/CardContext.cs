using CardGame.DAL.Dto;
using CardGame.DAL.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardGame.DAL
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
