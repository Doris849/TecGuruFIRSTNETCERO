using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.Polimorfismo
{
    //Polimorfismo
    //"Diferentes formas de hacer las cosas"

    //Polimorfismo por herencia: es cuando heredo una clase y utilizo 
    //sus propiedades de diferente forma "Virtual"

    //Polimorfismo por abstracción: cuando puedo heredar una clase  abstracta
    //y utilizo sus propiedades de diferente forma "Abstract"

    //Polimorfismo por Interface: es la manera de implementar una interdace de 
    //diferentes maneras "Interface"
    public abstract class Arma
    {
        //Virtual es un modificador que se usa para especificar
        //que un metodo , propiedad, clase se pueda modificar en una clase heredada,
        //ejemplo en la clase  virtual A -> la hereda la clase B :A  entonces 
        //la clase B va a a poder modificar las propiedades de la clase A

        //public Arma()
        //{

        //}

        public virtual string Recargar()
        {
            return "Recargando Arma";
        }

        //Abstract  es un modificador que me permitira modificar las propiedades y metodos 
        //de una clase heredada
        //1.-La diferencia con virtual  es que solo se define el metodo mas no se implementa
        //2.-Donde se herede la clase base, se obliga a implementar las propiedades metodos abstractos
        public abstract string Disparar();

        public int Folio { get; set; }
    }
}
