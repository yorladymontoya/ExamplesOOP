using System;
    namespace ejercicio1Opp
    {

        class ejemploHotelOop
        {
            //PROPIEDADES DE LA CLASE    ----EJEMPLO HOTEL---
            public string habitacion { get; set;}
            public int huesped { get; set;}
            //public int dias { get; set;}

            int Dias;
            public int dias {
            get { return Dias}
            set 
            {
                if(value >= 1)
                {
                    Dias = value;
                }else
                {
                    Console.WriteLine("Cantidad de dias debe ser minimo 1");
                }
            }
            }

            // METODOS
            public int valorEstadia(int huesp, int cantd){
                int TARINDIVIDUAL = 2500;
                int TARDOBLE = 4600;
                int TARFAMILIAR = 5200;
                int cobro=0;

                if(huesp == 1)
                {
                    cobro = cantd * TARINDIVIDUAL;
                }
                else
                {
                    if(huesped == 2)
                    {
                        cobro = cantd * TARDOBLE;
                    }    
                    else
                    {
                        if (huesp >= 3)
                        {
                        cobro = cantd * TARFAMILIAR;
                        } 
                        else
                        {
                            
                        }
                    }
                }
                        return cobro;
            }
         
            public void cuentaCobro(){
                int IVA = 19;
                int precioSinConIva = 0;
                int precioConIva = 0;
                precioSinConIva = valorEstadia(huesped, dias);

                precioConIva = ((precioSinConIva * IVA / 100) + precioSinConIva);

                Console.WriteLine(precioConIva);
            }
        }

    }

