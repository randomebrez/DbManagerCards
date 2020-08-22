using DAL.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mapping
{
    public class CardMap : IEntityTypeConfiguration<DbCard>
    {
        public void Configure(EntityTypeBuilder<DbCard> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("id");
            builder.Property(t => t.Name).HasColumnName("name");
        }
    }
}
