using HPT.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.Infrastructure.EntityConfig
{

    public class HistoricoConfig : IEntityTypeConfiguration<Historico>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Historico> builder)
        {

            #region Configurancao do Endereco

            builder.Property(x => x.Detalhe)
                .HasColumnType("varchar(200)");

            #endregion
        }
    }
}
