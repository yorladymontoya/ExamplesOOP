using System;

namespace ejercicio2{


    class Operaciones
    {
        //PROPIEDADES
        public string Marca {get; set;}
        public string Serie {get; set;}
        
            short modelo;
            public short Modelo {
            get
            {
                return modelo;
            }
            
            set 
            {
                 if (value > 2017 && value < 2022)
                {
                    modelo = value;
                }
                else
                {
                    System.Console.WriteLine("El modelo debe estar entre 2017 y 2022");
                }
            }
            }
        
        
        string placa;        
            public string Placa {
            get 
            {
                    return placa;
            }
            
            set
            {
                if (value.Length == 6 )
                {
                    placa= value;
                }
                else
                {
                    System.Console.WriteLine("Digite una placa valida, debe tener 6 digitos");
                }

            }
            
            }
        
        //METODOS
        public void prender()
        {
                Console.WriteLine("El vehiculo esta prendiendo");
        }


        
    }


}
