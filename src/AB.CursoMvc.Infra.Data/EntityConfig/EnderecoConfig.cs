﻿using AB.CursoMvc.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AB.CursoMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.Id);

            Property(e => e.Logradouro).IsRequired().HasMaxLength(150);
            Property(e => e.Numero).IsRequired().HasMaxLength(20);
            Property(e => e.Bairro).IsRequired().HasMaxLength(50);
            Property(e => e.CEP).IsRequired().HasMaxLength(8).IsFixedLength();
            Property(e => e.Complemento).HasMaxLength(100);

            HasRequired(e => e.Cliente).WithMany(c => c.Enderecos).HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");

        }
    }
}
