using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONCESIONARIO");
            
             Console.WriteLine("Digite La Marca");
            String marca = Console.ReadLine();

             Console.WriteLine("Digite La Serie");
            String serie = Console.ReadLine();

             Console.WriteLine("Digite el Modelo");
            short modelo = short.Parse(Console.ReadLine());

            Console.WriteLine("Digite la Placa");
            String placa = Console.ReadLine();

            // INSTANCIAMOS LA CLASE  QUE CREACMOS--- OPERACIONES
                var vehiculoUno= new Operaciones()
                {
                    Marca= marca,
                    Serie= serie,
                    Modelo= modelo,
                    Placa = placa
                };

                System.Console.WriteLine(vehiculoUno.Placa);
                System.Console.WriteLine(vehiculoUno.Modelo);
        }
    }
}
