using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// En c# no se permite la herencia múltiple, lo que quiere decir que no se puede heredar de mas de una clase a la vez

namespace TecGurusBasicUAMConsole.HerenciaNivelesAcceso
{
    public class Abuelo
    {
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

        public Abuelo() //Constructor
        {
            Nombre = "Alberto";
            CURP = "2123";
        }

        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        private string CURP { get; set; }

        internal string Reloj { get; set; }

        public void Terreno()
        {
            Console.WriteLine("casa del abuelo");
        }

        public void LeerNoticias()
        {
            Console.WriteLine("LeeNoticasconTele");
        }

}

        //Crear carpeta: EjercicioHerencia
        //Crear clase base Vehiculo con propiedad llantas int, puerta int,  acciones: acelerar void(), frenar void()
        //que impriman texto acelerando y texto frenando
        //Crear clase VehiculoAereo accion: volar ,aterrizar  y VehiculoTerrestre TotaldeVelocidades como propiedad,
        //ambas que hereden de Vehiculo
        //Crear clase avion que herede de VehiculoAereo  y crear clase coche que herede de VehiculoTerrestre
        //Implementar en un metodo en Main que imprima sus metodos      

}



