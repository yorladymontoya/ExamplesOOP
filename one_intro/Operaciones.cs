using System;

namespace one_intro

{
    class Operaciones
    {
         //Atributos (Propiedades - variables)
        public int numeroUno { get; set; }
        // Public = Modificador de Acceso.
        //  int = tipo de dato que va almacenar.
        // MyProperty (numeroUno)= nombre del atributo (Variable)
        // get = Metodos para entrega el valor de la propiedad
        // set = Metodos para recibe el valor de la propiedad

        public int numeroDos { get; set; }

        //Metodos (Funciones)
            
            // modificador de acceso
            // Tipo de retorno
            // nombreMetodo
            // (Argumentos (args) o parametros)
            
            //Metodos (Funciones)
            /*
             public void nuestraSuma(int n1, int n2)
            {
            int suma = n1 + n2;
            Console.WriteLine($"La suma de {n1} y {n2} es {suma}"); 
            }*/

            //Separar responsabilidades en los metodos
            public int calcularSuma(int n1, int n2)
            {
                 int resultadoSuma =0;
                 resultadoSuma= n1+n2;
                 return resultadoSuma;   
            }
        public void imprimirSuma(){
            Console.WriteLine("La suma es " +
             calcularSuma(numeroUno, numeroDos)); 
        }
    }

}