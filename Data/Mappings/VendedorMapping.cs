using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            // 1 : N => Vendedor : Produtos
            builder.HasMany(v => v.Produtos)
                .WithOne(p => p.Vendedor)
                .HasForeignKey(p => p.VendedorId);

            builder.ToTable("Vendedor");
        }
    }
}
