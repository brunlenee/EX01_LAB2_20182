using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.ApplicationCore.Entity
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public int ReservaId { get; set; }
        public List<Reserva> Reservas { get; set; }
    }
}
