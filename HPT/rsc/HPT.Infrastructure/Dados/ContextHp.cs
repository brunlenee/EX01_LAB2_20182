using HPT.ApplicationCore.Entity;
using HPT.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.Infrastructure.Dados
{
    public class ContextHp : DbContext
    {
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<ReservaHistorico> ReservaHistoricos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdHPD;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new HospedeConfig());

            modelBuilder.ApplyConfiguration(new HistoricoConfig());

            modelBuilder.ApplyConfiguration(new EnderecoConfig());

            modelBuilder.ApplyConfiguration(new CategoriaConfig());

        }
    }
}

