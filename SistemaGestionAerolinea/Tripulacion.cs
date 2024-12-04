using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public abstract class Tripulacion
    {
        public int NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public List<Vuelo> VuelosAsignados { get; set; } = new List<Vuelo>();

        public Tripulacion(int numeroIdentificacion, string nombre)
        {
            NumeroIdentificacion = numeroIdentificacion;
            Nombre = nombre;
        }

        public virtual void AgregarVuelo(Vuelo vuelo)
        {
            if (!VuelosAsignados.Contains(vuelo))
            {
                VuelosAsignados.Add(vuelo);
                Console.WriteLine($"\nVuelo {vuelo.NumeroVuelo} agregado a la lista de vuelos de {Nombre}");
            }
        }

        public virtual void QuitarVuelo(Vuelo vuelo)
        {
            if (VuelosAsignados.Contains(vuelo))
            {
                VuelosAsignados.Remove(vuelo);
                Console.WriteLine($"Vuelo {vuelo.NumeroVuelo} removido de la lista de vuelos de {Nombre}");
            }
        }






    }
}
