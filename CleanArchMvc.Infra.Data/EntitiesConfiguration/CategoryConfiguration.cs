using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration
{
    //Fluent Api para configurar as tabelas geradas pelo identity
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();

            //Popula a tabela ao executar a migration se elas não existirem na tabela
            builder.HasData(
                    new Category(1, "Material Escolar"),
                    new Category(2, "Eletrônicos"),
                    new Category(3, "Acessórios")
                );
        }
    }
}
