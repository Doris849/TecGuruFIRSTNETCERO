using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.HerenciaNivelesAcceso
{
    public class Padre: Abuelo
    {
        // constructor
        public Padre()
        {
            Nombre = "Jose Alberto";
            ApellidoP = "Alquicira";

        }

        // propiedad
        private string CURP { get; set; }

        public void Terreno()
        {
            Console.WriteLine("Departamentos");
        }


    }
}
