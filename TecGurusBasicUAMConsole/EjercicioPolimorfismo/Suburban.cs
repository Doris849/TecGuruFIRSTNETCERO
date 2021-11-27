using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioPolimorfismo
{
    public class Suburban: Viaje, IVehiculo
    {
        public string matricula { get; set; }

        //public int CantAsientos { get; set; }
        // constructor
        public Suburban(int cantAsientos, decimal costoxasiento)
        {
            this.TotalAsientos = cantAsientos;
            this.CostoxAsientos = costoxasiento;
        }

        public override decimal GananciaViaje()
        {
            return this.CostoxAsientos * this.TotalAsientos;
        }

    }
}
