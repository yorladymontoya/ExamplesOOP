using System; // System: es una liberria que trae por defecto - Generica.

namespace one_intro //Es el nombre de la carpeta del proyecto.
{
    class Program // Indica el archivo donde estoy codificando alguna funcionalidad especifica.
    {
        /* Atributos (Propiedades)
                Color, marca, placa, modelo, etc 
        */ 


        /* Metodos (Funciones)
                Arrancar, Acelerar, frenar, reversar, etc
        */
            static void Main(string[] args) // Main: es el metodo - (String: Tipo de dato del array [Aca se ponen los argumentos] - args: Nompre del array)
                {
                Console.WriteLine("Hello Yorlady you are the best!"); // Las instrucciones que uno quiere se ejecuten.

                   Console.WriteLine("Numero uno");
                   int numUno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero Dos");
                   int numDos = int.Parse(Console.ReadLine());
                     //int suma = numUno + numDos;
                     int suma = numUno + numDos;

                
    /* ESTA ES LA FORMA ESTRUCTURADA DE HACER UN CODIGO: CUANDO TODO EL CODIGO ESTA EN UNA MISMA PARTE

                        //Console.WriteLine("El numero es: " + numUno);
                        //Console.WriteLine($"La suma de {numUno}");

            // Diferentes forma de mostrar SUMA en la consola:

                        //Console.WriteLine($"La suma de {numUno} y {numDos} es {suma}"); // para concatenar en ves de + se usa $ y las llaves de con las variables dentro
                        Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos}");

            */


    // FORMA ORIENTADA A OBJETOS   - CADA COSA DEBE ESTAR EN UN LUGAR ESPECIFICO E INVOCARLO.
    // Instancia la class Operaciones)

    // Class     objeto(instancia)   (= y new reservadas sistema)    constructorDeLa Class()
    //Operaciones    myOperacion       = new                             Operaciones()
    
    var myOperacion = new Operaciones(){
        numeroUno = numUno, 
        numeroDos = numDos

    };

    // VErificar el valor que tiene almacenado la propiedad.
    //Console.WriteLine(myOperacion.numeroUno);

    // Llevar el valor como parametroa un metodo.
    // PAra hacer esto simplemente se llama el metodo de la CLASS mediante una instancia(OBJETO)
   // myOperacion.nuestraSuma(myOperacion.numeroUno, myOperacion.numeroDos);
    myOperacion.imprimirSuma();

}
}
}
