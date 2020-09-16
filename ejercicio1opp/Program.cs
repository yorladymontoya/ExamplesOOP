using System;

namespace ejercicio1Opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel WC");    
            Console.WriteLine("Cantidad de huespedes");
            int huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de dias de estadia");
            int cant_dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre habitacion");
            string nom_hab = (Console.ReadLine());

        //INTANCIA
        var hotelUno = new ejemploHotelOop(){
            habitacion = nom_hab,
            dias = cant_dias,
            huesped = huespedes
        };
        hotelUno.cuentaCobro();
            
        }
    }
}
