using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    public class Rifle : Arma
    {
        public override string Disparar()
        {
            return "Disparando rifle: pum  pum pum pum pum ";
        }
    }
}
