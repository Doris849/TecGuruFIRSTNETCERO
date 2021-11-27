using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioHerencia
{
    class VehiculoTerrestre: Vehiculo
    {
        // propiead
        public int TotalVelociodades { get; set; }

        // metodo implementado
        public override void Acelerar()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Frenando vehiculo terrestre");
        }
    }
}
