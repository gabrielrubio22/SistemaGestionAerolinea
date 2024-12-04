using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class AsignacionTripulacion
    {
        public string IdAsignacion { get; set; }
        public Vuelo Vuelo { get; set; }
        public Tripulacion Tripulacion { get; set; }

        public AsignacionTripulacion(string idAsignacion, Vuelo vuelo, Tripulacion tripulacion) 
        { 
            IdAsignacion = idAsignacion;
            Vuelo = vuelo;
            Tripulacion = tripulacion;
        }

        public void ConfirmarAsignacion()
        {
            Console.WriteLine($"Asignacion: {IdAsignacion} confirmada para el vuelo: {Vuelo.NumeroVuelo}");
        }

        public void CancelarVuelo()
        {
            Console.WriteLine($"Asignacion: {IdAsignacion} cancelada");
        }
    }
}
