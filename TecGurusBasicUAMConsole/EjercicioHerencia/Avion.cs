using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioHerencia
{
    class Avion : VehiculoAereo
    {
        private string Empresa { get; set; }
        //avion.Empresa = "Mexicana";

        override public void Acelerar()
        {
            Console.WriteLine("acelerando avion");
        }

        public void Volar()
        {
            Console.WriteLine("Volar avion");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizar avion");
        }


    }
}

    

