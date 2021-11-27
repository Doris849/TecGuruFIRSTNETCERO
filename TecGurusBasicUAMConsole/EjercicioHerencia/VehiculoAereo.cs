using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioHerencia
{
    class VehiculoAereo: Vehiculo
    {
        // propiedad
        public string Material { get; set; }

        //  metodo abstracto implementado
        public override void Acelerar()
        {
            Console.WriteLine("Frenando vehiculo aereo");
        }

        
    }
}
