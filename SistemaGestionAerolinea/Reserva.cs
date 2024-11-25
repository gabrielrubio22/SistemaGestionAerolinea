using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Reserva
    {
        public int NumeroReserva { get; set; }
        public Vuelo Vuelo { get; set; }
        public Pasajeros Pasajero { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; }

        public Reserva(int NumeroReserva, Pasajeros pasajero) { 
            this.NumeroReserva = NumeroReserva;
            this.Pasajero = pasajero;
        }

        public override string ToString()
        {
            return $"ID Reserva: {NumeroReserva}, Nombre Pasajero: {Pasajero}";
        }

        public void ConfirmarReserva()
        {
            Estado = "Confirmada";
            Console.WriteLine("Reserva Confirmada");
        }

        public void CancelarReserva()
        {
            Estado = "Cancelada";
            Console.WriteLine("Reserva Cancelada");
        }
    }
}
