using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.ApplicationCore.Entity
{
    public class ReservaHistorico
    {
        public int ReservaHistoricoId { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public int HistoricoId { get; set; }
        public Historico Historico { get; set; }
    }
}
