using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.POO
{
    class Calculadora
    {
        // propiedad
        public string Operacion { get; set; }

        // constructor
        public Calculadora(string operacion)
        {
            this.Operacion = operacion;
        }


        // metodo sobrecarga Suma 1. Sintaxis
        // modificador   tipo-de-datos  nombre-metodo   parámetros
        // {
        // tipo de datos  variable = operacion;
        // }
        public int Suma(int Cantidad1, int Cantidad2)
        {
            int resultado = Cantidad1 + Cantidad2;
            return resultado;
        }

        // metodo sobrecarga Suma 2
        public string Suma(int Cantidad1, int Cantidad2, int Cantidad3)
        {
            int resultado = Cantidad1 + Cantidad2 + Cantidad3;
            return Imprimir("Suma", resultado, Cantidad1, Cantidad2, Cantidad3);
        }


        public int Resta(int Cantidad1, int Cantidad2)
        {
            int resultado = Cantidad1 - Cantidad2;
            return resultado;
        }

        public string Resta(int Cantidad1, int Cantidad2, int Cantidad3)
        {
            int resultado = Cantidad1 - Cantidad2 - Cantidad3;
            return Imprimir("Resta", resultado, Cantidad1, Cantidad2, Cantidad3);
        }

        // metodo sobrecarga Imprimir 1
        public string Imprimir(string operacion, int resultado, int Cantidad1, int Cantidad2, int Cantidad3)
        {
            return (operacion + " =  " + resultado + " Cantidades: " + Cantidad1 + " , " + Cantidad2 + " y " + Cantidad3);
        }

        // metodo sobrecarga Imprimir 2
        public string Imprimir(string operacion, int resultado, int Cantidad1, int Cantidad2)
        {
            return (operacion + " =  " + resultado + " Cantidades: " + Cantidad1 + " y " + Cantidad2);
        }




    }
}


// Realizar la creacion de una clase llamada calculadora
//la cual al de la clase "inicio" solicite la operacion a a realizar puede ser : suma, resta
//crear los metodos pára realizar las operacion con 2 o 3 numeros ->sobrecarga de metodos:
//Metodo 1 regresa suma 2 numeros
//Metodo 2 Regresa suma 3 numeros y  saluda al usuario con la hora y fecha actual
//Se los dejo a su consideracion
//Tambien se puede solicitar al inicio la operacion a realizar y el nombre de usuario

/*        public string EfectuarOperacion(int Cantidad1, int Cantidad2, int Cantidad3) 
 *        {
            string resultadoOperacion="";


            if (tipoOperacion()) 
                resultadoOperacion=Suma(Cantidad1, Cantidad2, Cantidad3);
            else 
                resultadoOperacion=Resta(Cantidad1, Cantidad2, Cantidad3);
            

            return resultadoOperacion;
        }

        public int EfectuarOperacion(int Cantidad1, int Cantidad2)
        {
            int resultadoOperacion = 0;

            if (tipoOperacion())
                resultadoOperacion = Suma(Cantidad1, Cantidad2);
            else
                resultadoOperacion = Resta(Cantidad1, Cantidad2);


            return resultadoOperacion;
        }

        private Boolean tipoOperacion()
        {
            //Equals (String, String) es un método String. Se utiliza para determinar 
            //si dos objetos String tienen el mismo valor o no. Básicamente, verifica 
            //la igualdad. Si ambas cadenas tienen el mismo valor, devuelve verdadero; 
            //de lo contrario, devuelve falso. Este método es diferente de los métodos 
            //Compare y CompareTo. Este método compara dos cadenas según su contenido. Sintaxis:
            //bool string.Equals (string str1, string str2)
            //
            return string.Equals(this.Operacion, "suma");
        }

*/