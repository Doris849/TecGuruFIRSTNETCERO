using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.POO
{
    public class GrupoTarea
    {
        // propiedades de la clase Grupo establecidas por doris
        public int Clave { get; set; }
        public List<Alumno> ListAlumnos { get; set; }

        // con  new inicializo una clase que llama al constructor
        //

        // Constructor de la clase Grupo
        // con los parametros de entrada inicializo las propiedades
        // que considero necesarias para inicializar la clase
        //
        public GrupoTarea(int clave, List<Alumno> listalumnos)
        {
            this.Clave = clave;  // doris-tarea
            this.ListAlumnos = listalumnos; //  doris-tarea
        }


        //public static void listaStringAlum(Dictionary<string, Alumno> alumnosP)
        //{
        //    Console.WriteLine("Lista de alumnos \n");
        //    foreach (var item in alumnosP)
        //    {
        //        Console.WriteLine("Key: {0} Matricula: {1} Nombre {2}", item.Key, item.Value.Matricula, item.Value.Nombre);
        //    }
        //}


        public void ListaAlumnos()  // doris-tarea
        {
            foreach (var recorro in ListAlumnos)
            {
                Console.WriteLine("Matricula " + recorro.Matricula + " " + recorro.Nombre + " " + recorro.ApellidoP + " " + recorro.ApellidoM);

            }
        }



    }


}
