using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecGurusBasicUAMConsole.POO
{
    public class Grupo
    {
        // propiedades de la clase Grupo establecidas por profesor
        public int id { get; set; }
        public string Name { get; set; }


        public static void listaStringAlum(Dictionary<string, Alumno> alumnosP)
        {
            Console.WriteLine("Lista de alumnos \n");
            foreach (var item in alumnosP)
            {
                Console.WriteLine("Key: {0} Matricula: {1} Nombre {2}", item.Key, item.Value.Matricula, item.Value.Nombre);
            }
        }


    }


}
