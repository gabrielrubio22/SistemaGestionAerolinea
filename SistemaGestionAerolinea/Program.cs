using SistemaGestionAerolinea;

namespace Practica
{
    public class Program
    {
        static void Main(string[] args) {

            //Se crea lista de aviones
            List<Avion> aviones = new List<Avion>();

            Console.WriteLine("_________ Aviones _________");
            Console.WriteLine("");

            //se añade a la lista la instancia de nuevos aviones
            aviones.Add(new Avion(8, "Cessna 172", 10));
            aviones.Add(new Avion(5678, "Airbus A320", 180));

            //se recorre la lista de aviones para mirar su contenido
            foreach (var avion in aviones) { 
                Console.WriteLine($"Avión: {avion.Modelo}, Capacidad asientos: {avion.CapacidadAsientos}");
            }

            //se selecciona un solo avion para un vuelo en especifico
            Avion avionSeleccionado = aviones[1];

            //se crea un nuevo vuelo y se pasa el avion seleccionado.
            Vuelo vuelo1 = new Vuelo(287, "Bogota", "Madrid", avionSeleccionado,DateTime.Now.AddDays(7));
            
            Console.WriteLine("");
            Console.WriteLine("_________ Informacion Del Avion _________");
            Console.WriteLine("");
            avionSeleccionado.MostrarInformacion();

            Console.WriteLine("");
            Console.WriteLine("_________ Informacion Del Vuelo _________");
            Console.WriteLine("");
            vuelo1.MostrarDetalle();//se muestra informacion del vuelo creado

            //Se crea un nuevo pasajero
            Pasajeros pasajero1 = new Pasajeros(60368412,"Carlos Eduardo Rodiguez Garzon");

            //se crea una nueva reserva con el vuelo creado anteriormente.
            var reserva = pasajero1.ReservarVuelo(vuelo1);

            Console.WriteLine($"\nReserva creada por: {reserva.Pasajero.Nombre}");
            Console.WriteLine($"Numero: {reserva.NumeroReserva}, Vuelo: {reserva.Vuelo.NumeroVuelo}, Estado: {reserva.Estado}");

            Console.WriteLine("\nVuelos reservados por el pasajero:");
            pasajero1.MostrarVuelosReservados();

        }

    }

    
}


