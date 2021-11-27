using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    // cuando se pone :IArma y marca error, es porque no se ha implementado
    // la interfase IArma.serie
    class Pistola: IArma
    {
        // El atributo Serie se definio en IArma: string Serie { get; set; }
        public string Serie { get; set; }

        // Esto cuando se agregó el campo Serie sugerido por Jorge
    
        public Pistola(string serie)
        {
            // dentro del constructor se puede asignar valor al atributo Serie
            Serie = serie;
        }

        //public Pistola() 
        //{
        //    
        //}
        public string Limpiar()
        {
            return "Estoy en pistola y limpiando";
        }


    }
}
