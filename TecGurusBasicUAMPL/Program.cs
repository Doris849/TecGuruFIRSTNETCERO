using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecGurusBasicUAMBLL;
using TecGurusBasicUAMPL.Tarea1;

namespace TecGurusBasicUAMPL
{
    static class Program
    {



        ////////////////////////////////////
        ////////////////////////////////////
        // Prueba en rama Development 27/11/2021
        ////////////////////////////////////
        ///////////////////////////////////////






        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculadoraFRM());
        }

        static void AccessClass()
        {
            //No puedo tener Referencias circulares en los ensamblados
            GroupBLL group = new GroupBLL();
            //Tarea Establecer de inicio el formulario de inicio CalculadoraFRM
            //Y crear el formulario como la imagen para realizar la suma de dos valores
        }
    }
}
