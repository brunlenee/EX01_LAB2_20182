using HPT.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.Infrastructure.EntityConfig
{

    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {

            #region Configurancao do Endereco

            builder.Property(x => x.Descricao)
               .HasColumnType("varchar(150)");

            #endregion
        }
    }
}
