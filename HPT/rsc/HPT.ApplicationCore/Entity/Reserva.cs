using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.ApplicationCore.Entity
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int NumeroQuad { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal Valor { get; set; }
        public int HospedeId { get; set; }
        public List<Hospede> Hospedes { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<ReservaHistorico> ReservaHistoricos { get; set; }



    }
}
