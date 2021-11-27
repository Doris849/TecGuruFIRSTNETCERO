using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.POO
{
    public class Cajero
    {
        // Los constructores permiten al programador establecer valores predeterminados,
        // limitar la creación de instancias y escribir código flexible y fácil de leer.
        // En C# podemos definir un método que se ejecute inicialmente y en forma automática.
        // Este método se le llama constructor. Se declara la Propiedad y enseguida el constructor
        // El constructor tiene las siguientes características:
        // Tiene el mismo nombre de la clase.
        // Es el primer método que se ejecuta.
        // Se ejecuta en forma automática.
        // No puede retornar datos.
        // Se ejecuta una única vez.
        // Un constructor tiene por objetivo inicializar atributos.
        // Sintaxis de un Constructor en C#
        // Modificador NombredelaClase (Parámetros)
        // {
        //    Instrucciones
        // }
        // la diferencia principal entre constructor y método es que una constructor es un
        // método especial en una clase que inicializa objetos de esa clase, mientras que un método es
        // un procedimiento o una función que ejecuta un conjunto de instrucciones asociadas con una clase.


        // Sobrecarga de constructores  ////////////////////////////////////////////////////////
        public int NIP { get; set; } // propiedad

        // metodo o constructor que inicializa el valor de la propiedad NIP de la clase Cajero
        public Cajero(int nip)
        {
            this.NIP = nip;
        }

        // sobrecarga porque el metodo cajero es llamado desde otros lugares: Cajero cajero = new Cajero();
        public Cajero()
        {


        }

        // Realizar la creacion de una clase llamada calculadora
        // la cual al de la clase "inicio" solicite la operacion a a realizar puede ser : sum, res
        // crear los metodos pára realizar las operacion con 2 o 3 numeros ->sobrecarga de metodos:
        // Metodo 1 regresa suma 2 numeros
        // Metodo 2 Regresa suma 3 numeros y  saluda al usuario con la hora y fecha actual
        // Se los dejo a su consideracion
        // Tambien se puede solicitar al inicio la operacion a realizar y el nombre de usuario


        // Método, se clasifican en procedimientos (No devuelven valor)
        // y funciones (DEvuelven un valor)
        // Sintaxis:
        // Modificador de acceso (determina su visibilidad)
        // Tipo de dato (devuelto al finalizar su ejecución)
        // Identificador (Nombre coon el cual se invoca)
        // Parámetros (cero o mas variables que recibe el metodo)

        // Sobrecarga de metodos  ////////////////////////////////////////////////////////

        public int SumaComision (int Cantidad1, int Cantidad2)
        {
            return Cantidad1 + Cantidad2;
        }

        public int SumaComision(int Cantidad1, int Cantidad2, int Cantidad3)
        {
            return Cantidad1 + Cantidad2 + Cantidad3;
        }


        public string SumaComision(int Cantidad1, int Cantidad2, string mes)
        {
            //int    sumacant = Cantidad1 + Cantidad2;
            //string sumamsj = Convert.ToString(sumacant);
            //return  ("La comision del mes es " + Mes +"  "+ sumacant + " Cantidades: " + Cantidad1 + " y " + Cantidad2) ;
            //
            int operacion = Cantidad1 + Cantidad2;
            //
            //string Concat
            //
            string resultado = string.Concat("La operación del mes: ", mes, " es: ", operacion);
            return resultado;
        }

        public string SumaComision(int Cantidad1, int Cantidad2, int Cantidad3, string mes)
        {
            //int sumacant = Cantidad1 + Cantidad2 + Cantidad3;
            //string sumamsj = Convert.ToString(sumacant);
            //return ("La comision del mes es " + Mes + "  " + sumacant + " Cantidades: " + Cantidad1 + ", " + Cantidad2 + " y " + Cantidad3);
            //
            int operacion = Cantidad1 + Cantidad2 + Cantidad3;
            //
            //string format
            //
            string resultado = string.Format("La operación del mes: {0} es: {1}", mes, operacion);
            return resultado;

        }

    }
}
