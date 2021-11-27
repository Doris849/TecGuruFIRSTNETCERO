using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusBasicUAMConsole.POO;
using TecGurusBasicUAMConsole.HerenciaNivelesAcceso;
using TecGurusBasicUAMConsole.EjercicioHerencia;
using TecGurusBasicUAMConsole.Polimorfismo;
using TecGurusBasicUAMConsole.EjercicioPolimorfismo;

namespace TecGurusBasicUAMConsole
{
    class Program
    {

        //GAC Global Assembly Cache--> determinar con que librerias va a iniciar cada proyecto
        /// <summary>
        /// IDE Entorno de desarrollo integrado -> sirve para desarrollar codigo ejecutarlo deployarlo y hacermo debug
        /// C#   -> lenguajes
        /// Framework ->> .Net Framework ->4.7.2
        /// ¿Qué es un Framework?
        /// conjunto de librerias -> las librerias contienen clases-> es codigo que realiza cierta tarea o funcion
        /// Facilitar y agilizar el desarrollo de un aplicacion SqlClient , ItextSharp, Interop
        /// break point
        /// GUID Identificador único global
        /// </summary>
        static void Main(string[] args)
        {
            //MiPrimerClase();
            //EjercicioCta();
            //DiasSemana();
            //EdadAlumno();
            //ImplementacionCajero();
            //ImplementacionCajeroMes();
            //Constructores();
            //ConstructorCalcula();
            //GETandSET();
            //GETandSET2();
            //HerenciaExample();
            //EjercicioVehiculo();
            //ArrayExample();
            //ArrayTarea();
            //ImprimirFrutas();
            //ListAlumno();
            //PrintSemaforoStatus();
            //Alumno alumno = new Alumno("Masculino");
            //alumno.MiGenero();
            //Alumno alumno2 = new Alumno();
            //alumno2.MiGenero();

            //GetAlumnosDictionary();
            //GetAlumnosDictionaryEjemplo();
            //PrintAlumDiccSexo();
            //ExamplePolimorfismo();
            //ExamplePolimorfismoInterfase();
            EjercicioPolimorfismo();
        }

        public static void EjercicioPolimorfismo()
        {
            // Autobus
            Console.WriteLine("Cantidad de asientos del Autobus: ");
            int NumAsientosAutobus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Costo por asiento del Autobus: ");
            int CostoxAsientoAutobus = Convert.ToInt32(Console.ReadLine());

            Autobus autobus = new Autobus(NumAsientosAutobus, CostoxAsientoAutobus);
            Console.WriteLine("Total Autobus ");
            Console.WriteLine(autobus.GananciaViaje());

            // Suburban
            Console.WriteLine("Cantidad de asientos de Suburban: ");
            int NumAsientosSuburban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Costo por asiento del Suburban: ");
            int CostoxAsientoSuburban = Convert.ToInt32(Console.ReadLine());

            Suburban suburban = new Suburban(NumAsientosSuburban, CostoxAsientoSuburban);
            Console.WriteLine("Total Suburban ");
            Console.WriteLine(suburban.GananciaViaje());

            // matricula

            suburban.matricula = "2222222";
            autobus.matricula = "11111111";

            Console.WriteLine("Valor de autobus.matricula {0}", autobus.matricula);
            Console.WriteLine("Valor de suburban.matricula {0}", suburban.matricula);


            Console.ReadLine();
        }


        public static void ExamplePolimorfismoInterfase()
        {
            //   Pistola pistola = new Pistola();
            //   Console.WriteLine(pistola.Limpiar());
            // imprimir en consola los textos de las armas pistola y basuca
            //
            //Pistola pistola = new Pistola(); // antes de agregar el constructor
            //
            Pistola pistola = new Pistola("serie establecida por el constructor");
            Basuca basuca = new Basuca();
            basuca.Serie = "Numero de serie";
            List<IArma> Armas = new List<IArma> { pistola, basuca };
            foreach (var arma in Armas)
            {
                Console.WriteLine(arma.Limpiar());
            }
            Console.ReadLine();
        }

        public static void ExamplePolimorfismo()
        {
            Escopeta escopeta = new Escopeta();
            Rifle rifle = new Rifle();
            List<Arma> armas = new List<Arma> { escopeta, rifle };
            foreach (var arma in armas)
            {
                Console.WriteLine(arma.Recargar());
                Console.WriteLine(arma.Disparar());
            }
            // No se puede crear una instancia del tipo abstracto
            // o de la interfase IArma.
            //IArma arma1 = new IArma();
            Console.ReadLine();
        }


        public static void GetAlumnosDictionaryEjemplo()
        {
            Alumno alumno = new Alumno();
            Dictionary<int, string> semanasNuevas = new Dictionary<int, string>();
            semanasNuevas.Add(1, "Semana1");

            Dictionary<int, Grupo> gruposNuevos = new Dictionary<int, Grupo>();
            gruposNuevos.Add(1, new Grupo { id = 1, Name = "3d" });
            alumno.Semanas = semanasNuevas;
            alumno.Grupos = gruposNuevos;
            //Tarea Ejercicio -> Crear el siguiente dictionary donde el key sea el genero llenar 3 alumnos por genero 
            // e imprimirlos en consola
            Dictionary<int, List<Alumno>> alumnosGenero = new Dictionary<int, List<Alumno>>();

            Console.ReadLine();

        }


        //Dictionary consiste en una llave y un valor 
        public static Dictionary<int, string> GetSemaforoStatus()
        {
            //int,int string,string long,char  string,List<Alumno> string, int
            //Tarea Crear un metodo en Program llamado GetAlumnosDictionary
            //en otro metodo llamado ListaAlumnos de la clase Grupo ->crearla, imprimir todos los alumnos en consola
            //*obtener la lista de alumnos  ListaAlumnos(aqui recibe el diccionario) como parametro
            //Dictionary<int,Alumno>
            //int -> Matricula es la llave  y el value sera un Alumno

            Dictionary<int, string> semaforo = new Dictionary<int, string>();
            semaforo.Add(1, "Rojo");
            semaforo.Add(2, "Amarillo");
            semaforo.Add(3, "Verde");
            return semaforo;
        }
        public static void PrintAlumDiccSexo()
        {
            Grupo.listaStringAlum(GetAlumDictionarySexo());
            Console.ReadLine();
        }

        public static Dictionary<string, Alumno> GetAlumDictionarySexo()
        {
            Dictionary<string, Alumno> alumnosItem = new Dictionary<string, Alumno>();
            alumnosItem.Add("F", new Alumno { Matricula = 123, Nombre = "Mujer1", ApellidoP = "Paterno1", ApellidoM = "Materno1" });
            alumnosItem.Add("M", new Alumno { Matricula = 456, Nombre = "Hombre1", ApellidoP = "Paterno2", ApellidoM = "Materno2" });
            alumnosItem.Add("D", new Alumno { Matricula = 789, Nombre = "Desconocido", ApellidoP = "Paterno3", ApellidoM = "Materno3" });

            return alumnosItem;
        }

        public static void GetAlumnosDictionary()
        {
            Alumno alumno1 = new Alumno();
            alumno1.Matricula = 11111;
            alumno1.Nombre = "Name1";
            alumno1.ApellidoP = "Paterno1";
            alumno1.ApellidoM = "Materno1";

            Alumno alumno2 = new Alumno();
            alumno2.Matricula = 22222;
            alumno2.Nombre = "Name2";
            alumno2.ApellidoP = "Paterno2";
            alumno2.ApellidoM = "Materno2";

            Alumno alumno3 = new Alumno();
            alumno3.Matricula = 33333;
            alumno3.Nombre = "Name3";
            alumno3.ApellidoP = "Paterno3";
            alumno3.ApellidoM = "Materno3";

            List<Alumno> listAlumno = new List<Alumno>();
            listAlumno.Add(alumno1);
            listAlumno.Add(alumno2);
            listAlumno.Add(alumno3);

            // con  new inicializo una clase que llama al constructor
            // Grupo grupo = new Grupo(9, new List<Alumno>());
            // El grupo tiene la llave 9
            GrupoTarea grupoNuevo = new GrupoTarea(9, listAlumno);

            Console.WriteLine("Lista de alumnos: grupoNuevo.ListaAlumnos() ");
            grupoNuevo.ListaAlumnos();

            Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

            foreach (var alumno in grupoNuevo.ListAlumnos)
            {
                // Indico que la matricula es mi key y le asocio elobjeto alumno
                diccionarioAlumnos.Add(alumno.Matricula, alumno);
            }

            Console.WriteLine("\n Diccionario de alumnos: ");
            foreach (var diccionarioAlumno in diccionarioAlumnos)
            {
                Console.WriteLine(diccionarioAlumno.Key + " Matrícula <" + diccionarioAlumno.Value.Matricula + "> " + diccionarioAlumno.Value.Nombre + " " + diccionarioAlumno.Value.ApellidoP + " " + diccionarioAlumno.Value.ApellidoM);
            }

            Console.ReadLine();

        }


        public static void PrintSemaforoStatus()
        {
            var dictionarySemaforo = GetSemaforoStatus();
            foreach (var item in dictionarySemaforo)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();

        }



        /// <summary>
        /// Coleccion de datos es un conjunto de datos, de informacion, la cual esta almacenada para hacer uso de ella 
        /// No necesito especificar el tamaño de la lista
        /// </summary>
        /// 

        private static void Listas()
        {
            List<string> ListFrutas = new List<string>();
            ListFrutas.Add("Durazno");
            ListFrutas.Add("Manzana");
            ListFrutas.Add("Pera");
            ListFrutas.Add("Banana");
        }

        //ListasFrutas -> regrese coleccion con nombre de 5 frutas
        static List<string> GetFrutas()
        {
            List<string> ListFrutas = new List<string>();
            ListFrutas.Add("Durazno");
            ListFrutas.Add("Manzana");
            ListFrutas.Add("Pera");
            ListFrutas.Add("Banana");
            ListFrutas.Add("Fresa");
            return ListFrutas;
        }

        static void ImprimirFrutas()
        {
            var frutas = GetFrutas();
            //iteraciones loop ciclo bucle
            //un valor de inicio, condicional, incremento/decremento
            for (int i = 0; i < frutas.Count(); i++)
            {
                Console.WriteLine(frutas[i]);
            }

            Console.WriteLine("Frutas desde Foreach");
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            Console.ReadLine();
        }

        // 
        // Crear una lista del objeto alumno con 3 alumnos en un metodo que se llame ListAlumnos -> Program
        // crear metodo GetAlumno() -> ya que este obtendra la coleccion de alumnos de ListAlumnos,
        // y la enviara a imprimir al metodo PrintAlumnos
        //
        // imprimir todos los alumnos seperados por ****************
        // Imprimir desde un metodo llamdo PrintAlumnos * Nota el metodo debe estar en la clase alumno
        //
        // Solamente asignar e inprimir valores de las propiedades matricula, Nombre, ApellidoP, ApellidoM

        static void ListAlumno()
        {
            Alumno alumno1 = new Alumno();
            alumno1.Matricula = 1;
            alumno1.Nombre = "Name1";
            alumno1.ApellidoP = "Paterno1";
            alumno1.ApellidoM = "Materno1";

            Alumno alumno2 = new Alumno();
            alumno2.Matricula = 2;
            alumno2.Nombre = "Name2";
            alumno2.ApellidoP = "Paterno2";
            alumno2.ApellidoM = "Materno2";

            Alumno alumno3 = new Alumno();
            alumno3.Matricula = 3;
            alumno3.Nombre = "Name3";
            alumno3.ApellidoP = "Paterno3";
            alumno3.ApellidoM = "Materno3";

            List<Alumno> listAlumno = new List<Alumno>();
            listAlumno.Add(alumno1);
            listAlumno.Add(alumno2);
            listAlumno.Add(alumno3);

            GetAlumno(listAlumno);
        }

        static void GetAlumno(List<Alumno> listAlumno)
        {
            //iteraciones loop ciclo bucle
            //un valor de inicio, condicional, incremento/decremento
            for (int i = 0; i < listAlumno.Count(); i++)
            {
                listAlumno[i].PrintAlumno();
            }
            Console.ReadLine();
        }


        //static void PrintListAlumnos(List<Alumno> listAlumno)
        //{
        //
        //}


        //Crear arreglo con los dias de la semana e imprimirlos en consola
        //*opcion a ciclo 
        static void ArrayTarea()
        {
            string[] arrayDiaSem = new string[7];
            Console.WriteLine("Dias de la semana");
            for (int counter = 0; counter <= 6; counter++)
            {
                switch (counter)
                {
                    case 0: arrayDiaSem[0] = "Lunes"; break;
                    case 1: arrayDiaSem[1] = "Martes"; break;
                    case 2: arrayDiaSem[2] = "Miercoles"; break;
                    case 3: arrayDiaSem[3] = "Jueves"; break;
                    case 4: arrayDiaSem[4] = "Viernes"; break;
                    case 5: arrayDiaSem[5] = "Sabado"; break;
                    default: arrayDiaSem[6] = "Domingo"; break;
                }
                Console.WriteLine(arrayDiaSem[counter]);
            }
            Console.ReadLine();
        }

        //Arreglo es una estructura de datos se almacena informacion
        //en memoria, puede ser del mismo tipo o diferentes tipos de datos
        //es de base 0 --> el primero espacio del array seria 0
        // el segundo es 1 , | 0| 1 | 2 | 3 | -> este array tiene 4 espacios
        //         valores--->5   8   3   1
        static void ArrayExample()
        {

            int[] array1 = new int[4];
            array1[0] = 5;
            array1[1] = 8;
            array1[2] = 3;
            array1[3] = 1;
            //Esto cuando compile no sera posible
            //array1[4] = 5;
            //array1[5] = 6;
            //Console.WriteLine(array1[4]);
            Console.WriteLine(array1[2]);

            int[] array2 = new int[] { 1, 2, 5, 8 };
            Console.WriteLine(array2[2]);

            int[,] array3 = { { 1, 2, 5, 8 }, { 9, 7, 3, 6 } };
            Console.WriteLine(array3[0, 2]);
            Console.WriteLine(array3[1, 1]);
            Console.WriteLine(array3[0, 3]);

            //Crear arreglo con los dias de la semana e imprimirlos en consola
            //*opcion a ciclo 

            Console.ReadLine();


        }



        static void EjercicioVehiculo()
        {
            Avion avion = new Avion();
            avion.Acelerar();
            avion.Frenar();

            avion.Volar();
            avion.Aterrizar();


            avion.Material = "Acero";
            Console.WriteLine("Material del avion: {0}", avion.Material);

            Coche coche = new Coche();
            coche.Acelerar();
            coche.Frenar();

            Console.ReadLine();

            // Vehiculo es una clase abstacta por lo tanto no es posible generar ejemplares
            // es decir, objetos.
            //Vehiculo avion11 = new Vehiculo();//error
            Vehiculo avion1 = new Avion();
            Vehiculo coche1 = new Coche();

            // Avion y Coche son clases concretas por lo tanto es posible crear 
            // ejemplares
            Avion avion2 = new Avion();
            Avion avion3 = new Avion();
            Coche coche4 = new Coche();

            reciboVehiculo(avion1);
            reciboVehiculo(coche1);
        }

        static void reciboVehiculo(Vehiculo vehiculo)
        {

            vehiculo.Acelerar();
        }

        static void HerenciaExample()
        {
            // Se crea el objeto abuelo
            Abuelo abuelo = new Abuelo();
            Console.WriteLine("Desde la clase ABUELO Nombre del abuelo: {0}", abuelo.Nombre);

            // Se crea el ejemplar padre de la clase Padre
            Padre padre = new Padre();
            padre.Terreno();

            Hijo hijo = new Hijo();
            hijo.Terreno();

            Console.WriteLine("Desde la clase HIJO Nombre del abuelo: {0}", hijo.Nombre);

            Console.ReadLine();
        }

        static void GETandSET2()
        {
            Alumno alumno = new Alumno();
            //alumno.Grado = "3A";
            //Console.WriteLine(alumno.Grado.ToString());
            //Console.WriteLine(Convert.ToString(alumno.Grado));
            Console.WriteLine("Ingresa el mes del alumno: ");
            //alumno.MES = int.Parse(Console.ReadLine());
            alumno.MESNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine(alumno.NombreMes);

            Console.ReadLine();
        }

        //crear en otro metodo la siguiente implementacion:
        //solicitar al usuario ingrese el numero de mes de nacimiento
        //ejemplo si  es 1 entonces imprimeremos Enero .... 4 -> si es mayor a 12 o menor a 1 
        //asignar mes invalido
        //*Utilizando el procedimiento get y set
        //el string del mes en este caso Enero debe "setearse" en una propiedad de Alumno

        static void GETandSET()
        {
            Alumno alumno = new Alumno();
            //alumno.Grado = "3A";
            //Console.WriteLine(alumno.Grado.ToString());
            //Console.WriteLine(Convert.ToString(alumno.Grado));
            Console.WriteLine("Ingresa el mes del alumno: ");
            //alumno.MES = int.Parse(Console.ReadLine());
            alumno.MES = Convert.ToInt32(
                Console.ReadLine());
            if (alumno.MES != 0)
            {

                Console.WriteLine("El mes del alumno es : " + alumno.MES);
            }
            else
            {
                Console.WriteLine("" + "El mes ingresado no existe!!!");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Diferencias, es el tamaño de espacio que utiliza en Byte,
        /// Diferencia es la precision , y exactitud cercania, precision aritmetica
        /// </summary>
        /// 
        static void Example()
        {
            //ejemplo de presicion:
            //12.12 a 12.1256987

            //int intValueN = -2147483648; //Int
            //int intValueP = 2147483648; //Int que ya es un valor asignado fuera de rango
            //long longValue = 2147483648L; //bigint

            //float floatValue = 12.56F;//
            //double doubleValue = 12.56;//double
            //decimal decimalValue = 12.89M;//decimal

        }


        static void ConstructorCalcula()
        {
            // Se llama al constructor para inicializar el campo operacion
            // de la clase Calculadora
            Console.WriteLine("**** ingrese operacion suma / resta ***");
            string operacion = (Console.ReadLine());
            Calculadora calculadora = new Calculadora(operacion);

            Console.WriteLine("**** ingrese nombre usuario ***");
            string usuario = (Console.ReadLine());

            Console.WriteLine("**** ingrese Total de operandos 2 o 3 : ***");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            DateTime tiempoActual = DateTime.Now;
            string Rdo_xx;
            int RdoNum;

            if (cantidad == 2)
            {
                // Se devuelve un numero. 2 argumentos
                if (operacion == "suma")
                {
                    RdoNum = calculadora.Suma(800, 200);

                }
                else
                {
                    RdoNum = calculadora.Resta(800, 200);

                }
                Console.WriteLine(usuario + " en fecha " + tiempoActual + " Se efectuo la operación " + calculadora.Imprimir(operacion, RdoNum, 800, 200));
            }
            else
            {
                // Se devuelve una cadena. 3 argumentos
                if (operacion == "suma")
                {
                    Rdo_xx = calculadora.Suma(800, 200, 50);

                }
                else
                {
                    Rdo_xx = calculadora.Resta(800, 200, 50);

                }
                Console.WriteLine(usuario + " en fecha " + tiempoActual + " Se efectuo la operación " + Rdo_xx);

            }

            Console.ReadLine();
        }


        // Los constructores permiten al programador establecer valores predeterminados,
        // limitar la creación de instancias y escribir código flexible y fácil de leer.
        // En C# podemos definir un método que se ejecute inicialmente y en forma automática.
        // Este método se lo llama constructor.

        static void Constructores()
        {
            // Creamos objeto de la clase y le pasamos los parametros al constructor
            Cajero cajero = new Cajero(1234);

            // Pinto el NIP, con la propiedad de la clase porque el constructor inicializa 
            // propiedades de mi clase
            Console.WriteLine(cajero.NIP);
            Console.ReadLine();
        }


        //Para formatear texto
        //ctrl + k suelto ctrl + d
        // Para debug es con F10 linea por linea, para irme a un metodo F11


        static void ImplementacionCajero()
        {
            Cajero cajero = new Cajero();
            int sumaComision;
            Console.WriteLine("**** ingrese Total de comisiones a sumar: ***");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad > 2)
            {
                sumaComision = cajero.SumaComision(100, 200, 300);
                Console.WriteLine(sumaComision);
            }
            else
            {
                sumaComision = cajero.SumaComision(100, 200);
                Console.WriteLine(sumaComision);
            }
            Console.ReadLine();

        }

        static void ImplementacionCajeroMes()
        {
            Cajero cajero = new Cajero();
            Console.WriteLine("**** ingrese Mes de comisiones a sumar: ***");
            string mes = (Console.ReadLine());
            Console.WriteLine("**** ingrese Total de comisiones a sumar: ***");
            string sumaComision;
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad > 2)
            {
                sumaComision = cajero.SumaComision(100, 200, 300, mes);

            }
            else
            {
                sumaComision = cajero.SumaComision(100, 200, mes);
            }
            Console.WriteLine(sumaComision);
            Console.ReadLine();
        }


        static void DiasSemana()
        {
            Alumno alumno = new Alumno();
            Console.WriteLine("***Ingresa un numero de la semana:***");
            var dia = Console.ReadLine();

            //Conversion de datos
            int DiaEntero = Convert.ToInt32(dia);

            // Se asigna valor a la variable DiaCadena con el resultado del metodo
            // peryteneciente a la clase Alumno, del objeto alumno.
            string DiaCadena = alumno.DiaSemanaCondicional(DiaEntero);
            Console.WriteLine("El día de la semana es: " + DiaCadena);


            // Detener 
            //Console.ReadLine();
        }

        static void EdadAlumno()
        {
            Alumno alumno2 = new Alumno();
            //tarea 2
            // string currentMonth = DateTime.Now.Month.ToString();
            //string currentYear = DateTime.Now.Year.ToString();
            // https://stackoverflow.com/questions/3890956/how-to-get-current-month-and-year/3891003

            // Solicita con var datos por consola, independientemente de su tipo
            Console.WriteLine("***Ingresa el año de nacimiento:***");
            var AnioNacim = Console.ReadLine();
            // convierte la string AnioNacim en tipo Entero
            int anioNacInt = Convert.ToInt32(AnioNacim);
            // Evalua el valor del metodo CalculaEdad que pertenece al objeto alumno2
            // que es un ejemplar (instancia) de la clase Alumno.
            if (alumno2.CalculaEdad(anioNacInt) > 0)
            {
                //alumno.Edad = alumno.CalculaEdad(anioNacInt);
                //Console.WriteLine("La edad actual es: " + alumno.CalculaEdad(anioNacInt));
                Console.WriteLine("La edad actual es: " + alumno2.Edad);
            }
            else
            {
                Console.WriteLine("Usuario no existe");
            }

            // Detener 
            Console.ReadLine();
        }


        static void MiPrimerClase()
        {
            // Tarea: Crear mi primer objeto seteando valor a cada una
            // de mis propiedades, y mostrando todas las propiedades en consola
            // Creacion de primer objeto
            //
            // Para crear un objeto de Alumno, especifique el nombre de la clase,
            // seguido del nombre del objeto y use la palabra clave new:
            Alumno alumno = new Alumno();
            alumno.Edad = 15;
            alumno.Nombre = "Ruben";
            Console.WriteLine("Hola mi nombre: " + alumno.Nombre);
            alumno.Saludo();
            string dia = alumno.DiaSemana();
            // comandos equivalentes
            Console.WriteLine(dia);
            Console.WriteLine(alumno.DiaSemana());
            //
            Console.ReadLine();
            Console.WriteLine("***Otro saludo***");
            Console.ReadLine();
        }


        //Objeto -> Carro
        //--->propiedades: Color,Marca,Transmision
        //--->Acciones:  Desplazarse "Avanzar",Frenar, Colision, Apagado, encendido
        //Carro Dodge= new Carro();

        //Alumno:--> Clase  : es la representancion conceptual de un objeto ->> el modelo o molde donde voy a contener
        // la definicion de las propiedades y metodos de un objeto
        // El objeto es cuando se crea y es manejable
        //Edad,Estado Academico, Carrera, ApellidoP,ApellidoM,Nombre, Segundo Nombre ->propiedad de algun tipo de dato
        //ejemplo Edad seria Entero->Int
        //Inscribirse()--> fue satisfactorio o no ->metodo -->Diferentes tipos de metodos
        //AprobarGrado()---> Sumatoria de todas sus calificaciones en base a un promedio minimo

        //Cuando se realiza la instancia de una clase -> una clase se convierte en un objeto-
        //Alumno alumno1 = new Alumno(); ----> esto es una instancia de un objeto por lo tanto ahora puedo acceder 
        // mediante el objeto pedro a sus propiedades y acciones
        // alumno1.Nombre, alumno1.ApellidoP, alumno1.ApellidoM

        //Polimorfismo                                Herencia  :
        //Vehiculo -->         Avion                                    ,   Carro
        //Puertas, Motor      Puertas, Motor                              Puertas, Motor
        //Desplazarse()       Aceleracion + distancia +abrirAlas       aceleracion +Distancia  

        /*
            static void ConstructorCalcula()
            {
                Calculadora calculadora = new Calculadora("suma");
                Console.WriteLine(calculadora.EfectuarOperacion(100, 200, 300));

                Calculadora calculadora2 = new Calculadora("resta");
                Console.WriteLine(calculadora2.EfectuarOperacion(900, 200, 100));

                Calculadora calculadora3 = new Calculadora("suma");
                Console.WriteLine(calculadora3.EfectuarOperacion(100, 200));

                Calculadora calculadora4 = new Calculadora("resta");
                Console.WriteLine(calculadora4.EfectuarOperacion(900, 100));

                Console.ReadLine();
            }
        */

        static void EjercicioCta()
        {
            // Se llama al constructor para inicializar el campo operacion
            // de la clase Cuenta

            Console.WriteLine("**** ingrese numero del titular ***");
            var titularString = (Console.ReadLine());
            int titularInt = Convert.ToInt32(titularString);
            Cuenta cuenta = new Cuenta(titularInt);



            Console.WriteLine("**** ingrese cantidad a depositar ***");
            var cantidadstring = (Console.ReadLine());
            double cantidadDouble = Convert.ToInt64(cantidadstring);
            cuenta.Ingresar(cantidadDouble);
            Console.WriteLine("** Cantidad depositada ** cuenta.cantidad: {0}", cuenta.Cantidad);

            Console.WriteLine("**** ¿ cantidad a retirar ? ***");
            var cantidadstri = (Console.ReadLine());
            double cantidadDou = Convert.ToInt64(cantidadstri);

            Console.WriteLine("** Despues de Retirar {0} ** queda en la cuenta: {1} ", cantidadDou, cuenta.Retirar(cantidadDou));

            Console.ReadLine();

        }

    }
}
