using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Vuelo
    {
        public int NumeroVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Avion Avion { get; set; }
        public List<Reserva> ListaPasajeros { get; set; } = new List<Reserva>();
        public List<AsignacionTripulacion> ListaTripulacion { get; set; } = new List<AsignacionTripulacion>();
        public DateTime FechaHoraSalida { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Vuelo: {NumeroVuelo} de {Origen} a {Destino}");
            Console.WriteLine($"Fecha y hora de salida: {FechaHoraSalida}");
            Console.WriteLine($"Avion: {Avion.Modelo}");
        }

        public bool TineAsientosDisponibles()
        {
            return true;
        }

        //Constructor de la clase Vuelo
        public Vuelo(int NumeroVuelo, string Origen, string Destino, Avion avion, DateTime fechaHoraSalida)
        {
            this.NumeroVuelo = NumeroVuelo;
            this.Origen = Origen;   
            this.Destino = Destino;
            this.Avion = avion;
            this.FechaHoraSalida = fechaHoraSalida;

            avion.AgregarVuelo(this);
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Numero de vuelo: {NumeroVuelo} con origen {Origen} y destino a {Destino}");
            Console.WriteLine($"Fecha y hora de salida: {FechaHoraSalida}");
            Console.WriteLine($"Avion: {Avion.Modelo}");

        }

        public bool TieneAsientosDisponibles()
        {
            return ListaPasajeros.Count < Avion.CapacidadAsientos;
        }
    }
}
