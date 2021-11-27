using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioHerencia
{
    class Coche:VehiculoTerrestre
    {
        private string Marca { get; set; }
        private string Color { get; set; }

        override public void Acelerar()
        {
            Console.WriteLine("acelerando coche");
        }


    }
}
