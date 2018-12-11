using HPT.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.Infrastructure.EntityConfig
{

    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Endereco> builder)
        {

            #region Configurancao do Endereco



            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)");
            builder.Property(x => x.CEP)
               .HasColumnType("varchar(150)");
            builder.Property(x => x.Numero)
               .HasColumnType("varchar(40)");
            builder.Property(x => x.Logradouro)
               .HasColumnType("varchar(150)");

            #endregion
        }
    }
}
