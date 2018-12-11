using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.ApplicationCore.Entity
{
    public class Historico
    {
        public int HistoricoId { get; set; }
        public string Detalhe { get; set; }
        public DateTime DateHora { get; set; }
        public List<ReservaHistorico> ReservaHistoricos { get; set; }
    }
}
