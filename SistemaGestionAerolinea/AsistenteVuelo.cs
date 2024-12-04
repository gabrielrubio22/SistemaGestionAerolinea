using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class AsistenteVuelo : Tripulacion
    {
        public string CertificacionAsistente { get; set; }

        public AsistenteVuelo(int numeroIdentificacion, string nombre, string certificado)
            :base(numeroIdentificacion, nombre)
        {
            CertificacionAsistente = certificado;
        }

        public void AsistirPasajeros()
        {
            Console.WriteLine($"Auxiliar {Nombre} esta asistiendo a los pasajeros");
        }
    }
}
