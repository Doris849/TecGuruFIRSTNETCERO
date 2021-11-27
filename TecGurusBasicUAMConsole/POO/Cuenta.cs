using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
//El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumplan lo anterior.
//Crea sus métodos get, set y toString.
//Tendrá dos métodos especiales:
//ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, 
//no se hará nada. 
//retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la 
//que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.


namespace TecGurusBasicUAMConsole.POO
{
    class Cuenta
    {
        public int Titular { get; set; }
        public double Cantidad { get; set; }

        // constructores
        public Cuenta (int titularP)
        {
            if (titularP > 0)
            {
                this.Titular = titularP;
            }
 
            else
            {
                Console.WriteLine("Error. Se requiere ingresar el numero del titular ");
            }
        }

        public Cuenta(double cantidadP)
        {
            this.Cantidad = cantidadP;            
        }

        // metodos
        public Boolean Ingresar(double cantidadP)
        {
            if (cantidadP < 0)
            {

                //string Msj = "Ingreso una Cantidad negativa";
                return false;
            }
            else
            {
                this.Cantidad = cantidadP;
                //string Msj = "Ingreso una Cantidad no negativa";
                return true;
            }
        }

        //retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la 
        //que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
        public double Retirar (double cantRetirar)
        {
            this.Cantidad  = this.Cantidad - cantRetirar;
            if (this.Cantidad < 0)
            {
                this.Cantidad = 0;
            }
            return this.Cantidad;
        }

    } // fin de la clase
}
