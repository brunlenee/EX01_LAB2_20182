using HPT.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.Infrastructure.EntityConfig
{

    public class HospedeConfig : IEntityTypeConfiguration<Hospede>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hospede> builder)
        {

            #region Configurancao do Endereco

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)");
            builder.Property(x => x.Email)
               .HasColumnType("varchar(100)");

            #endregion
        }
    }
}
