using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Piloto : Tripulacion
    {
        public string LicenciaPiloto { get; set; }

        public Piloto(int numeroIdentificacion, string nombre, string licencia)
            :base(numeroIdentificacion, nombre)
        {
            LicenciaPiloto = licencia;
        }

        public void Volar(Vuelo vuelo)
        {
            Console.WriteLine($"Piloto {Nombre} esta volando el vuelo {vuelo.NumeroVuelo}");
        }


    }
}
