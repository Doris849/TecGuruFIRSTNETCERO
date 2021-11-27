//Estas son las referencias a librerias y/o clases que utilizare
//en esta clase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// El nameSpace es mi lugar de trabajo
/// Hace a referencia a donde se encuentra alojada la clase
/// </summary>
namespace TecGurusBasicUAMConsole.POO
{
    public class Alumno
    {
        //tipos de datos primitivos:
        //int, string, bool,double,decimal,long etc.

        // public: desde cualquier lugar

        //Cuando una variable se declara directamente en una clase, a menudo se la denomina campo (o atributo).
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Edad { get; set; }

        public Dictionary<int, string> Semanas { get; set; }
        public Dictionary<int, Grupo> Grupos { get; set; }

        private string Genero { get; set; }


        // protected: solo por herencia. sólo la clase en la que se ha utilizado el modificador
        // y sus clases derivadas tendrán acceso al miembro o tipo definido como protected.
        protected string ADN { get; set; }

        // internal: dentro del proyecto, sólo serán accesibles desde los archivos del mismo ensamblado
        internal string Grado { get; set; }

        public Alumno()
        {

        }

        public Alumno(string genero)
        {
            Genero = genero;
        }

        public void MiGenero()
        {
            if (!string.IsNullOrEmpty(Genero))
            {
                Console.WriteLine("Mi genero es: " + Genero);
            }
            else
            {
                Console.WriteLine("Asigna Genero ");
            }
            Console.ReadLine();
        }



        // public es un modificador de acceso -> cuando una clase propiedad o
        // metodo son  publicos, cualquier otra clase
        // va a tener  acceso a dichas propiedades, tambien otros proyectos 

        // Un modificador de acceso son palabras reservadas que delimitan el
        // "Uso a clases, propiedades, metodos"


        // private Los miembros privados sólo son accesibles dentro
        // de la clase en la que se definen (una clase externa no tiene acceso a ella).
        // Sin embargo, a veces necesitamos acceder a ellos, y se puede hacer con propiedades.
        //
        // La ENCAPSULACIÓN es asegurarse de que los datos "sensibles"
        // estén ocultos a los usuarios. Para lograr esto, debes:
        // * declarar campos / variables como private
        // * proporcionar public get y set métodos, a través de propiedades, 
        //   para acceder y actualizar el valor de un private campo

        private int mes;  // field privado. the variable name
        // Una propiedad es como una combinación de una variable y un método,
        // y tiene dos métodos:  get y set
        public int MES    // property de la variable. The Name-MES property is associated with the name field-mes.
                          // It is a good practice to use the mismo nombre for both the property
                          // and the private field, but with an uppercase first letter.
        {
            get { return mes; }   // get method. method returns the value of the variable name (mes)
            set                   // set method. The set method assigns a value to the name variable (mes).
                                  // The value keyword represents the value we assign to the property.
            {
                if (value > 0 && value < 13)
                {
                    mes = value;
                }
                else
                {
                    mes = 0;
                }
            }
        }


        public string NombreMes { get; set; }   // property NombreMes de la clase Alumno.
        public int MESNumero  // property MESNumero de la clase Alumno, pero se aprovecha para
                              // establecer el valor-value del campo privado mes y al mismo tiempo
                              // para asignar-setear el valor de MESNumero.
        {
            get
            {
                return mes;
            }
            set
            {
                mes = value;
                switch (value)
                {
                    case 1:  NombreMes = "Enero";   break;
                    case 2:  NombreMes = "Febrero"; break;
                    case 3:  NombreMes = "Marzo";   break;
                    case 4:  NombreMes = "Abril";   break;
                    case 5:  NombreMes = "Mayo";    break;
                    case 6:  NombreMes = "Junio";   break;
                    case 7:  NombreMes = "Julio";   break;
                    case 8:  NombreMes = "Agosto";  break;
                    case 9:  NombreMes = "Septiembre"; break;
                    case 10: NombreMes = "Octubre";    break;
                    case 11: NombreMes = "Noviembre";  break;
                    case 12: NombreMes = "Diciembre";  break;
                    default:
                        {
                            mes = 0;
                            NombreMes = "El mes no existe";
                        }
                        break;
                }
            }
        }

        //Los metodos se pueden agrupar en 2 partes, aquellos que regresan un valor
        //y los que no; es decir, simplemente realizan una acción
            /// <summary>
            /// No regresa valores
            /// </summary>
        public void Saludo()
        {
            Console.WriteLine("***Hola Mundo1***");
            Console.WriteLine("***Hola Mundo2***");
            Console.WriteLine("***Hola Mundo3***");
        }

        /// <summary>
        /// Regresa un valor dependiendo la definicion
        /// de metodo en este caso string
        /// </summary>
        /// <returns></returns>
        public string DiaSemana()  // metodo que regresa un valor. No requiere parámetros
        {
            //string dia = "Jueves";
            return "Jueves";
        }


        //Tipos de metodos que regresan valor:
        //int,string,bool,double,char,long,  DateTime, Puede regresar un objeto o coleccion de un objeto
        //public Alumno GetAlumno()-->internamente tendria que ver la manera de regresar un objeto tipo alumno

        //un metodo tambien puede recibir valores como parametros, para procesarlos , tomar desiciones, realizar operaciones

        //F10 sirve para debbugear linea por linea
        public string DiaSemanaCondicional(int dia) // metodo que regresa un valor STRING dependiendo
                                                    // del parámetro INT de entrada
        {
            string diaTexto = string.Empty; // si una cadena es null , su valor es String.Empty

            //una condicional sirve para evaluar si cumple o no con mis requerimientos "limitantes"
            //para poder realizar algun proceso
            //el if indica que si cumple mi limitante pasa a realizar mi proceso
            if (dia == 1)
            {
                diaTexto = "Lunes";
            }
            else if (dia == 2)
            {
                diaTexto = "Martes";
            }
            else if (dia == 3)
            {
                diaTexto = "Miercoles";
            }
            else if (dia == 4)
            {
                diaTexto = "Jueves";
            }
            else if (dia == 5)
            {
                diaTexto = "Viernes";
            }
            else if (dia == 6)
            {
                diaTexto = "Sabado";
            }
            else if (dia == 7)
            {
                diaTexto = "Domingo";
            }
            else
            {
                diaTexto = "No existe el dia";
            }

            return diaTexto;
        }

        //Cualquier tipo de valor que acepta valores NULL es una instancia de la estructura genérica System
        public int? CalculaEdad(int anioNacim) //metodo que recibe parametro INT, devuelve ó no un valor INT
        {
            DateTime tiempoActual = DateTime.Now;  // DateTime.Today
            //https://aprenderaprogramar.com/foros/index.php?topic=4968.0
            //https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/nullable-value-types
            //Console.WriteLine("El día de hoy es: " + tiempoActual.Day);
            //Console.WriteLine("El año es: " + tiempoActual.Year);
            if (anioNacim > tiempoActual.Year)
            {
                return null;
            }
            else
            {
                this.Edad = tiempoActual.Year - anioNacim;
                if (this.Edad > 1900)
                {
                    this.Edad = this.Edad - 1900;
                }
                return this.Edad;
            }
        }



        //Tarea 1 al metodo DiaSemanaCondicional de la clase alumno implementar una condicional
        // que sriva para evaluar en dado caso que se salga del rango del 1 al 7 , si sale de 
        //ese rango regresar un texto que diga : "No existe el día"

        //Tarea 2 Dentro de la clase Alumno Crear un metodo llamado  que reciba
        //el año de su nacimiento y calcule su edad a el año actual

        //*Nota para regresar el valor del metodo CalculaEdad  debo usar la propiedad Edad
        //de la clase Alumno

        //*Puntos extra---> Para practicar podrian usar DateTime

        //*Condicional si el año que ingreso es mayor al año actual el usuario no existe

        public void PrintAlumno() // metodo que no devuelve ningun valor y tampoco recibe valor
                                  // solo toma las varibales definidas de ésta clase.
        {
            Console.WriteLine(this.Matricula + this.Nombre + this.ApellidoP + this.ApellidoM + "*********** \n");
            // salto linea concatener cadena y adentro de comillas "kjhjh" + "\n"+     
        }

    } // fin de la clase Alumno


}  // fin de namespace
