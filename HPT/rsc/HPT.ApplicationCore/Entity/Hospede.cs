using System;
using System.Collections.Generic;
using System.Text;

namespace HPT.ApplicationCore.Entity
{
    public class Hospede
    {
        public int HospedeId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int ReservaId { get; set; }
        public Reserva Reserva { get; set; }
        public Endereco Endereco { get; set; }
    }
}
