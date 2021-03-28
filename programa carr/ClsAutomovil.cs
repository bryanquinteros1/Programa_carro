using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacarrr.clases
{
    class ClsAutomovil
    {


        public string marca { get; }
        public int vel_max { get; }

        private int velocidadActual { get; set; }

        private bool encendido = false;

        public string color { get; set; }



        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Lo Lamento, llegaste a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadActual}KPH";

            }
        }



        public bool EstaEncendido()
        {
            return encendido;

        }


        public string Frenar()
        {
            if (!encendido)
            {
                return "El carro no esta encendido";
            }

            velocidadActual = 0;
            return "Carrito se detuvo";

        }

        public string apagarAuto()
        {
            if (!encendido)
            {
                return "Enciende el carro por favor";
            }

            velocidadActual = 0;
            return "El carrito esta apagado";

        }








        public ClsAutomovil(string marcaCarro, int velocidadMx)

        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;

        }

        public string EncenderMotor()

        {
            if (encendido)
            {
                return "El carro ya esta encendido";

            }
            else
            {
                encendido = true;
                velocidadActual = 0;
                return "Listo|!| carro encendido";

            }










        }


    }
}

    

