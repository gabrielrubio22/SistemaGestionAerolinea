using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Avion
    {
        public int NumeroSerie { get; set; }
        public string Modelo { get; set; }
        public int CapacidadAsientos { get; set; }
        public List<Vuelo> vuelosAsignados { get; set; } = new List<Vuelo>();

        //Constructor de la clase Avion
        public Avion(int numeroSerie, string modelo, int capacidadAsientos) {

            if(capacidadAsientos <= 0)
            {
                throw new ArgumentException("La capacidad de asientos debe ser mayor a cero");
            }
            this.NumeroSerie = numeroSerie;
            this.Modelo = modelo;
            this.CapacidadAsientos = capacidadAsientos;
        }

        public void AgregarVuelo(Vuelo vuelo)
        {
            if (!vuelosAsignados.Contains(vuelo))
            {
                vuelosAsignados.Add(vuelo);
                Console.WriteLine($"Vuelo {vuelo.NumeroVuelo} esta asignado al avion {Modelo}");
            }
            else
            {
                Console.WriteLine($"El vuelo: {vuelo.NumeroVuelo} ya esta signado a este avion");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Avion: {Modelo} (Núm. de serie: {NumeroSerie})");
            Console.WriteLine($"Capacidad {CapacidadAsientos}");
            Console.WriteLine($"Vuelos asignados: {vuelosAsignados.Count}");
        }
    }

    
}
