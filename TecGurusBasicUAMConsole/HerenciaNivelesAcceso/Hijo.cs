using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.HerenciaNivelesAcceso
{
    public class Hijo : Padre
    {
        public int Edad { get; set; }
        private string CURP { get; set; }
        private string ApellidoMaterno { get; set; }
    }
}
