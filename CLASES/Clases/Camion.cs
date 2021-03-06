using System;//camion
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camion_moto_camioneta.Clases
{
    internal class Camion
    {
        public string Marca { get; }

        public int Modelo { get; }

        public string owner { get; set; }

        public String Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }

        public Camion(string _marca, int _modelo, string _color, int maxvel, string bocina, string soltarfulgon)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.velocidad_actual = 0;
        }

        public Camion(string _marca, int maxvel, string dueno)
        {
            Marca = _marca;
            MAXVELOCIDAD = maxvel;
            owner = dueno;
        }

        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"La velocidad del CaMion es {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = " vas muy rapido!!!";
            }

            return mensaje;
        }

        public string acelerar(int AcekerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El camion esta apagado !";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += AcekerarAkph;
                mensaje = $"El camion va a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas Calmado Broh ";
            }

            return mensaje;
        }

        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }


        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                Console.WriteLine(" camion encendido!!");
                velocidad_actual = 0;

            }
            else
            {
                Console.WriteLine("El camion ya estaba encendido");
            }
        }
        public String DameInformacion()
        {
            return $"Soy un camion marca {Marca} y mi modelo es {Modelo}";

        }

        public string Bocina()
        {


            string mensaje = "";



            mensaje = "Toco la bocina !";


            Console.WriteLine(mensaje);
            return mensaje;

        }

        public string soltarfulgon()
        {


            string mensaje = "";



            mensaje = "TEN CUIDADO!!";


            Console.WriteLine(mensaje);
            return mensaje;
        }
    }
}