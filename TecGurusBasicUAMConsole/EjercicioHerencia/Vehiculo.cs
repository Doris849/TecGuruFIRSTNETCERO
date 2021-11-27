using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.EjercicioHerencia
{
    abstract class Vehiculo
    {
        // propiedades
        public int Llantas { get; set; }
        public int Puertas { get; set; }

        //  El modificador abstract se puede utilizar con clases, métodos, propiedades, indizadores y eventos.
        //  El modificador abstract se utiliza principalmente para definir clases base, obligándo a las clases
        //  derivadas a implementar los miembros marcados con abstract. Si en una clase se definen miembros
        //  marcados con abstract, la clase debe marcarse como abstract. Si en una clase se definen miembros marcados
        //  con abstract, la clase debe marcarse como abstract.
        //  Las clases marcadas con abstract no se pueden instanciar. Debido a que las clases abstractas suelen ser
        //  clases base, no se pueden modificar con el modificador sealed, que hace que la clase no se pueda derivar
        //  Una clase no abstracta derivada de una clase abstracta debe incluir implementaciones reales de todos los
        //  descriptores de acceso y métodos abstractos heredados. Si defino métodos como abstract, estoy indicando
        //  que el método no contiene implementación, por tanto, los métodos abstractos son lo mismo que los métodos
        //  virtuales(virtual) ya que obligan a las clases derivadas a implementarlos.Sólo se pueden definir métodos
        //  abstractos en las clases abstractas.
        abstract public void Acelerar();

        // metodo 
        public void Frenar()
        {
            Console.WriteLine("Frenar");
        }

    }
}
