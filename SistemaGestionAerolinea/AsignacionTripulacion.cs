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
    }
}
