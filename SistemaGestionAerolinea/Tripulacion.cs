using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionAerolinea
{
    public class Tripulacion
    {
        public int NumeroIdentificacion { get; set; }
        public int Nombre { get; set; }
        public List<Vuelo> VuelosAsignados { get; set; }
    }
}
