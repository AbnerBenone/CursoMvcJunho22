﻿using AB.CursoMvc.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AB.CursoMvc.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(150);

            Property(c => c.CPF).IsRequired().HasMaxLength(11).IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF") { IsUnique = true }));

            Property(c => c.Email).IsRequired().HasMaxLength(100);
            Property(c => c.DataNascimento).IsRequired();
            Property(c => c.Ativo).IsRequired();
            Property(c => c.Excluido).IsRequired();

            ToTable("Clientes");
        }

    }
}
