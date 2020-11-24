using Altran.Cotacao.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Infra.Data.Mapeamentos
{
    public class ProdutoMap : MapBase<Produto>
    {
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
            builder.ToTable("Produto");
            builder.Property(c => c.Family_Id).IsRequired().HasColumnName("Family").HasMaxLength(50);
            builder.Property(c => c.Class).IsRequired().HasColumnName("Class").HasMaxLength(50);
            builder.Property(c => c.Gender).IsRequired().HasColumnName("Gender").HasMaxLength(1);
            builder.Property(c => c.Age).IsRequired();
            builder.Property(c => c.Rate).IsRequired();
        }
    }
}
