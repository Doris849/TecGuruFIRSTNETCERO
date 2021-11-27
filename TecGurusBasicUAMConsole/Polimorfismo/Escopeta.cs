using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    public class Escopeta : Arma
    {
        public override string Recargar()
        {
            //string recargaescopeta = "Recargando escopeta bala por bala";
            //return recargaescopeta;
            return base.Recargar() + " tipo Escopeta bala por bala";

        }

        public override string Disparar()
        {
            return "Disparando Escopeta: PUMMM PUMM";
        }

    }
}
