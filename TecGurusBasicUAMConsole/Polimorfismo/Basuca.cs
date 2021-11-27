using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    // inicialmente solo tenía la herencia de la interfase IArma.
    // se puede incluir doble herencia. Primero va la clase y después la interfase
    // al hacerlo, marca error la clase Basuca porque no tiene implementado
    // el metodo abstracto Arma.Disparar(), ya no Recargar de Arma porque ya
    // está implementado:
    //public virtual string Recargar()
    //{
    //    return "Recargando Arma";
    //}

    class Basuca : Arma, IArma
    {
        public string Limpiar()
        {
            return "Desmontando basuca y limpiando";
        }

        public string Serie { get; set; }

        // Fue necesario incluir la implementación de Disparar()  porque se agrego
        // la herencia de la clase
        public override string Disparar()
        {
            return "Disparando Basuca por hetencia de clase Arma: PUMMMMMMMMMMMMMM";
        }


    } // fin de clase
}
