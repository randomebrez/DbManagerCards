using DAL.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mapping
{
    public class DeckLinkMap : IEntityTypeConfiguration<DbDeckLink>
    {
        public void Configure(EntityTypeBuilder<DbDeckLink> builder)
        {
            builder.HasKey("id");
            builder.Property(t => t.Id).HasColumnName("id");
            builder.Property(t => t.DeckId).HasColumnName("deckId");
            builder.Property(t => t.CardId).HasColumnName("cardId");
            builder.HasOne(t => t.Deck)
                .WithMany(t => t.DeckLinks)
                .HasForeignKey("deckId");
            builder.HasOne(t => t.Card)
                .WithMany(t => t.DeckLinks)
                .HasForeignKey("cardId");
        }
    }
}
