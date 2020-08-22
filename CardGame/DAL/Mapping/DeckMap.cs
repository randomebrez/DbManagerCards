using CardGame.DAL.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.DAL.Mapping
{
    public class DeckMap : IEntityTypeConfiguration<DbDeck>
    {
        public void Configure(EntityTypeBuilder<DbDeck> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("id");
            builder.Property(t => t.Name).HasColumnName("name");
        }
    }
}
