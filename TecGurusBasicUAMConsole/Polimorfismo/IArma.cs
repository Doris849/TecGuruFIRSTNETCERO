using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    public interface IArma
    {
        // similitud con abstract
        // es que debo implementar cada una de sus propiedades y metodos tal cual esta definido 
        // (tipo de dato, cantidad de parametros)
        // no puedo crear instancias
        // solo se define mas no se implementa
        //
        //Diferencias con abstract
        //
        // definir un metodo
        // Que no necesito especificar un modificador de acceso ya que todo lo que se define
        // en una interfase es publico

        //string serie { get; set; }
        string Limpiar();
        string Serie { get; set; }



    }
}
