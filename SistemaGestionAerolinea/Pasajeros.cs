using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Pasajeros
    {   
        //Atributos
        public int NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }//Modificadores get y set
        public List<Reserva> reservas;

        //constructor
        public Pasajeros(int NumeroIdentificacion, string Nombre)
        {
            this.NumeroIdentificacion = NumeroIdentificacion;
            this.Nombre = Nombre;
            this.reservas = new List<Reserva>();
        }


        //Metodos de la clase
        public Reserva ReservarVuelo(Vuelo vuelo)
        {
            Reserva nuevaReserva = new Reserva(reservas.Count + 1, this)
            {
                Vuelo = vuelo,
                FechaReserva = DateTime.Now,
                Estado = "Confirmada"
            };
            reservas.Add(nuevaReserva);
            return nuevaReserva;
        }

        public void CancelarReserva(Reserva reserva)
        {
            if (reservas.Contains(reserva))
            {
                reserva.CancelarReserva();
                reserva.Estado = "Cancelada";
                Console.WriteLine($"Reserva: {reserva.NumeroReserva} cancelada.");
            }
            else
            {
                Console.WriteLine("La reserva no pertenece a este pasajero");
            }
        }

        public void MostrarVuelosReservados()
        {
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"Reserva: {reserva.NumeroReserva}, Vuelo: {reserva.Vuelo.NumeroVuelo}");
            }
            
        }
    }
}
